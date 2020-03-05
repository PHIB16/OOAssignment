//Author: Bradley Phipps & Oliver Rooney

using System;
using System.Drawing;

namespace ImageManipulator
{
    /// <summary>
    /// A factory for creating images using a provided filepath
    /// </summary>
    public class ImgFactory : IImageFactory
    {
        /// <summary>
        /// creates a .net image file based on the filepath passed as a parameter
        /// </summary>
        /// <param name="pFilePath">the filepath of the image</param>
        /// <returns>.NET image object </returns>
        public Image CreateImage(String pFilePath)
        {
            //
            return Image.FromFile(pFilePath);
        }
    }
}
