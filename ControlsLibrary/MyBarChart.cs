using System;

namespace ControlsLibrary
{
    public class MyBarChart
    {
        public string Label { get; set; }
        public float Value { get; set; }

        public MyBarChart(string label, float value)
        {
            Label = label;
            Value = value;
        }
    }
}
