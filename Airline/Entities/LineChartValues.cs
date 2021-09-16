using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Entities
{
    public class LineChartValues
    {
        public string Label { get; set; }
        public float Value { get; set; }

        public LineChartValues(string label, float value)
        {
            Label = label;
            Value = value;
        }
    }
}
