using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.GrapeVariety
{
    internal class UpdateGrapeVarietyRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Name { get; set; }
    }
}
