using System;
using System.Collections.Generic;
using System.Text;

namespace Moryx.Factory
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class CellPropertyUnitAttribute : Attribute
    {
        public CellPropertyUnitAttribute(string unit = "km") { 
            this._unit = unit;
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
        }

    }
}
