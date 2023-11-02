using ChampagneMaui.Models.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Champagne
{
    internal class ChampagneResponseModel
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public float AlcoholLevel { get; set; }

        public string Aging { get; set; }

        public DateTime BottlingDate { get; set; }
    }
}
