using System;
using System.Collections.Generic;
using System.Text;

namespace Moryx.Factory
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class CellImageURLAttribute : Attribute
    {
        public CellImageURLAttribute(string imageURL)
        {
            this._imageURL = imageURL;
        }

        private string _imageURL;

        public string ImageURL
        {
            get { return _imageURL; }
        }

    }
}
