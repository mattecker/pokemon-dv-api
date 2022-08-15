using System.ComponentModel.DataAnnotations;

namespace PokémonDV.Api.Models
{
    public class StatSet
    {
        [Required]
        [Range(2, 100, ErrorMessage = "Level must be from 2-100")]
        public byte Level { get; set; }

        [Required]
        [Range(10, 708, ErrorMessage = "HP must be from 10-708")]
        public ushort HP { get; set; }

        [Required]
        [Range(5, 458, ErrorMessage = "Attack must be from 5-458")]
        public ushort Attack { get; set; }

        [Required]
        [Range(5, 458, ErrorMessage = "Defense must be from 5-458")]
        public ushort Defense { get; set; }

        [Required]
        [Range(5, 458, ErrorMessage = "Speed must be from 5-458")]
        public ushort Speed { get; set; }

        [Required]
        [Range(5, 458, ErrorMessage = "Special must be from 5-458")]
        public ushort Special { get; set; }
    }
}
