using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokémonDV.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokémonDV.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokémonDVController : ControllerBase
    {
        private readonly PokémonContext _context;
        private readonly ILogger<PokémonDVController> _logger;

        public PokémonDVController(ILogger<PokémonDVController> logger, PokémonContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("{species}")]
        public BaseStatSet GetBaseStats(string species)
        {
            return _context.BaseStats.FirstOrDefault(x => x.Species == species);
        }

        [HttpPost("{species}/dv")]
        public string GetDVs(string species, List<StatSet> statSets, int levelCaught = 0)
        {
            BaseStatSet baseStats = GetBaseStats(species);
            List<DVSet> dvList = new();

            foreach (var statSet in statSets)
            {
                bool justCaught = statSet.Level == levelCaught;
                DVSet dv = new()
                {
                    Attack = DVCalculations.GetDV(statSet.Level, statSet.Attack, baseStats.Attack, justCaught),
                    Defense = DVCalculations.GetDV(statSet.Level, statSet.Defense, baseStats.Defense, justCaught),
                    Special = DVCalculations.GetDV(statSet.Level, statSet.Special, baseStats.Special, justCaught),
                    Speed = DVCalculations.GetDV(statSet.Level, statSet.Speed, baseStats.Speed, justCaught),
                };

                dv.HP = DVCalculations.GetHPDV(statSet.Level, statSet.HP, baseStats.HP, dv, justCaught);

                dvList.Add(dv);
            }

            DVSet dvs = dvList[0];
            for (int i = 1; i < dvList.Count; i++)
            {
                dvs = dvs.Intersect(dvList[i]);
            }

            return dvs.ToString();
        }
    }
}
