using PokémonDV.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokémonDV.Api
{
    public static class DVCalculations
    {
        private static readonly byte _minDV = 0;
        private static readonly byte _maxDV = 15;

        private static readonly byte _minStatPoint = 0;
        private static readonly byte _maxStatPoint = 63;

        public static DV GetDV(byte level, ushort stat, byte baseStat, bool justCaught = false)
        {
            if (justCaught)
                return CalcPossibleDVsJustCaught(level, stat, baseStat, _minDV, _maxDV);
            else
                return CalcPossibleDVs(level, stat, baseStat, _minDV, _maxDV);
        }

        public static DV GetHPDV(byte level, ushort stat, byte baseStat, DVSet dvSet, bool justCaught = false)
        {
            bool attackOdd = Enumerable.Range(dvSet.Attack.Min, dvSet.Attack.Max).Where(x => x % 2 == 1).Any();
            bool defenseOdd = Enumerable.Range(dvSet.Defense.Min, dvSet.Defense.Max).Where(x => x % 2 == 1).Any();
            bool specialOdd = Enumerable.Range(dvSet.Special.Min, dvSet.Special.Max).Where(x => x % 2 == 1).Any();
            bool speedOdd = Enumerable.Range(dvSet.Speed.Min, dvSet.Speed.Max).Where(x => x % 2 == 1).Any();

            bool attackEven = Enumerable.Range(dvSet.Attack.Min, dvSet.Attack.Max).Where(x => x % 2 == 0).Any();
            bool defenseEven = Enumerable.Range(dvSet.Defense.Min, dvSet.Defense.Max).Where(x => x % 2 == 0).Any();
            bool specialEven = Enumerable.Range(dvSet.Special.Min, dvSet.Special.Max).Where(x => x % 2 == 0).Any();
            bool speedEven = Enumerable.Range(dvSet.Speed.Min, dvSet.Speed.Max).Where(x => x % 2 == 0).Any();

            byte minHPDV = (byte)((attackEven ? 0 : 8) + (defenseEven ? 0 : 4) + (specialEven ? 0 : 1) + (speedEven ? 0 : 2));
            byte maxHPDV = (byte)((attackOdd ? 8 : 0) + (defenseOdd ? 4 : 0) + (specialOdd ? 1 : 0) + (speedOdd ? 2 : 0));

            if (justCaught)
                return CalcPossibleDVsJustCaught(level, stat, baseStat, minHPDV, maxHPDV, true);
            else
                return CalcPossibleDVs(level, stat, baseStat, minHPDV, maxHPDV, true);
        }

        private static DV CalcPossibleDVs(byte level, ushort stat, byte baseStat, byte minDV, byte maxDV, bool hp = false)
        {
            List<byte> dvs = new();
            for (byte dv = minDV; dv <= maxDV; dv++)
            {
                for (byte statPoint = _minStatPoint; statPoint <= _maxStatPoint; statPoint++)
                {
                    ushort calcStat = (ushort)((byte)((((baseStat + dv) * 2) + statPoint) * level / 100) + (hp ? level + 10 : 5));
                    if (stat == calcStat)
                    {
                        dvs.Add(dv);
                        break;
                    }
                    else if (stat < calcStat)
                    {
                        break;
                    }
                }
            }

            return new DV
            {
                Min = dvs.Min(),
                Max = dvs.Max()
            };
        }

        private static DV CalcPossibleDVsJustCaught(byte level, ushort stat, byte baseStat, byte minDV, byte maxDV, bool hp = false)
        {
            List<byte> dvs = new();
            for (byte dv = minDV; dv <= maxDV; dv++)
            {
                ushort calcStat = (ushort)((byte)((baseStat + dv) * 2 * level / 100) + (hp ? level + 10 : 5));
                if (stat == calcStat)
                {
                    dvs.Add(dv);
                }
                else if (stat < calcStat)
                {
                    break;
                }
            }

            return new DV
            {
                Min = dvs.Min(),
                Max = dvs.Max()
            };
        }
    }
}
