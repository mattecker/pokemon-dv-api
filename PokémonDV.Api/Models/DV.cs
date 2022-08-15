using System;
using System.ComponentModel.DataAnnotations;

namespace PokémonDV.Api.Models
{
    public class DV
    {
        [Range(0, 15, ErrorMessage = "Min must be 0-15")]
        public byte Min { get; set; }

        [Range(0, 15, ErrorMessage = "Max must be 0-15")]
        public byte Max { get; set; }

        public DV Intersect(DV dv2)
        {
            if (Min > dv2.Max || Max < dv2.Min)
                throw new ArgumentException();

            dv2.Min = Math.Max(Min, dv2.Min);
            dv2.Max = Math.Min(Max, dv2.Max);

            return dv2;
        }

        public override string ToString()
        {
            return Min == Max ? Min.ToString() : $"{Min}-{Max}";
        }
    }
}
