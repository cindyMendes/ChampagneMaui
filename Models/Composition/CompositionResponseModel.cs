using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models.Composition
{
    internal class CompositionResponseModel
    {
        public int Id { get; set; }

        public int ChampagneId { get; set; }

        public int GrapeVarietyId { get; set; }

        public int Percentage { get; set; }
    }
}
