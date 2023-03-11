using System;
using System.Collections.Generic;
using System.Text;

namespace Moryx.Factory
{
    public class EntryVisualizationAttribute : Attribute
    {
        public EntryVisualizationAttribute(string unit, string icon)
        {
            Unit = unit;
            Icon = icon;
        }

        public string Unit { get; }

        public string Icon { get; }
    }
}
