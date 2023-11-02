using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Champagne
{
    internal class ChampagneByNameRequestModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Name { get; set; } 
    }
}
