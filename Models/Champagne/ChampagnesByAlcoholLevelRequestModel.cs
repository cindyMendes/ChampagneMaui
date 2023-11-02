using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Champagne
{
    internal class ChampagnesByAlcoholLevelRequestModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public float Threshold { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Sign { get; set; }
    }
}
