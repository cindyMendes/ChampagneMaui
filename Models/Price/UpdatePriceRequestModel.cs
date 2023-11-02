using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Price
{
    internal class UpdatePriceRequestModel
    {
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This field cannot be empty")]
        public int ChampagneId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "This field cannot be empty")]
        public int SizeId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public float SellingPrice { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Currency { get; set; }
    }
}
