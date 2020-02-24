using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    class ImageStore: IImageStore
    {
        private IDictionary<string, Image> _imageDict = new Dictionary<string, Image>();

        public ImageStore()
        {
            
        }
        /// <summary>
        /// Returns Key of next index in _imageDict
        /// </summary>
        /// <returns>key string of next index</returns>
        private string Next()
        {

            return "";
        }
        /// <summary>
        /// Returns key of previous index in _imageDict
        /// </summary>
        /// <returns>Key string of previous index</returns>
        private string Previous()
        {

            return "";
        }
    }
}
