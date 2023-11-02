using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Size
{
    internal class SizeResponseModel
    {
        public int Id { get; set; }

        public string NameFR { get; set; }

        public string NameEN { get; set; }

        public string DescriptionFR { get; set; }

        public string DescriptionEN { get; set; }
    }
}
