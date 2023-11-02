using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Composition
{
    internal class UpdateCompositionRequestModel
    {
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This field cannot be empty")]
        public int ChampagneId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This field cannot be empty")]
        public int GrapeVarietyId { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "The value must be between 1 and 100")]
        public int Percentage { get; set; }
    }
}
