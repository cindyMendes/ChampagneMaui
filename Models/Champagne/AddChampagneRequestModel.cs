using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Champagne
{
    internal class AddChampagneRequestModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public float AlcoholLevel { get; set; }

        //[Required(ErrorMessage = "This field cannot be empty")]
        //public string Aging { get; set; }

        [Required]
        public DateTime BottlingDate { get; set; }
    }
}
