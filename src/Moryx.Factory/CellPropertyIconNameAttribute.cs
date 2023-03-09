using System;
using System.Collections.Generic;
using System.Text;

namespace Moryx.Factory
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class CellPropertyIconNameAttribute : Attribute
    {
        public CellPropertyIconNameAttribute(string googleFontIconName = "build") 
        {
            this._iconName = googleFontIconName;
        }

        private string _iconName;

        public string IconName
        {
            get { return _iconName; }
        }


    }
}
