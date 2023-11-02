using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Size;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Price
{
    internal class PriceResponseModel
    {
        public int Id { get; set; }

        public int ChampagneId { get; set; }

        public int SizeId { get; set; }

        public float SellingPrice { get; set; }

        public string Currency { get; set; }
    }
}
