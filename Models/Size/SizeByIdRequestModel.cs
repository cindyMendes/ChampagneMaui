using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Size
{
    internal class SizeByIdRequestModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        public int Id { get; set; }
    }
}
