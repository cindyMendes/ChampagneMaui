#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Models
{
    internal class MainResponseModel
    {
        public bool IsSuccess { get; set; } = true;

        public string? Message { get; set; }

        public object? Content { get; set; }
    }
}
