using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Size
{
    internal class UpdateSizeRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string NameEN { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string NameFR { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string DescriptionEN { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string DescriptionFR { get; set; }

    }
}
