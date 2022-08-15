namespace PokémonDV.Api.Models
{
    public class DVSet
    {
        public DV HP { get; set; }
        public DV Attack { get; set; }
        public DV Defense { get; set; }
        public DV Speed { get; set; }
        public DV Special { get; set; }

        public DVSet Intersect(DVSet set2)
        {
            return new DVSet
            {
                HP = HP.Intersect(set2.HP),
                Attack = Attack.Intersect(set2.Attack),
                Defense = Defense.Intersect(set2.Defense),
                Speed = Speed.Intersect(set2.Speed),
                Special = Special.Intersect(set2.Special)
            };
        }

        public override string ToString()
        {
            return $"HP: {HP}" +
                    $"\nAttack: {Attack}" +
                    $"\nDefense: {Defense}" +
                    $"\nSpeed: {Speed}" +
                    $"\nSpecial: {Special}";
        }
    }
}
