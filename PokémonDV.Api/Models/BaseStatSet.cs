namespace PokémonDV.Api.Models
{
    public class BaseStatSet
    {
        public byte PokédexId { get; set; }
        public string Species { get; set; }
        public byte HP { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte Speed { get; set; }
        public byte Special { get; set; }
    }
}
