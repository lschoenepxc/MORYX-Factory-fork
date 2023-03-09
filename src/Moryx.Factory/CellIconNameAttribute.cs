using System;
using System.Collections.Generic;
using System.Text;

namespace Moryx.Factory
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class CellIconNameAttribute : Attribute
    {
        public CellIconNameAttribute(string googleFontIconName) {
            this._iconName = googleFontIconName;
        }

        private string _iconName;

        public string IconName
        {
            get { return _iconName; }
        }

    }
}
