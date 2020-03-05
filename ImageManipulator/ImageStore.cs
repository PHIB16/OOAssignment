using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    /// <summary>
    /// 
    /// </summary>
    class ImageStore: IImageStore
    {

        //A private dictionary variable, called _ImageDict - Stores a string filepath as the key and a .net image as the value 
        private IDictionary<string, Image> _imageDict = new Dictionary<string, Image>();

        public ImageStore()
        {
            
        }
        /// <summary>
        /// Returns Key of next index in _imageDict
        /// </summary>
        /// <returns>key string of next index</returns>
        private Image Next()
        {

            return null;
        }
        /// <summary>
        /// Returns key of previous index in _imageDict
        /// </summary>
        /// <returns>Key string of previous index</returns>
        private Image Previous()
        {

            return null;
        }
    }
}
