//Author: Bradley Phipps & Oliver Rooney
using System;
using System.Drawing;

namespace ImageManipulator
{
    /// <summary>
    /// Interface for image data, will allow an implementing class to retrieve an image as standard or as a scaled version
    /// </summary>
    public interface IImageData
    {
        /// <summary>
        /// finds the value in the image dictionary based on the passed in key, this is then returned as its stored.
        /// </summary>
        /// <param name="Key">the key value for the image dictionary, storing the image filepath</param>
        /// <returns>A .Net image object </returns>
        Image RetrieveImage(String Key);
        /// <summary>
        /// finds the value in the image dictionary based on the passed in key, this is then returned as a scaled version based on the pHeight/ pWidth params.
        /// </summary>
        /// <param name="pKey">the key value for the image dictionary, storing the image filepath</param>
        /// <param name="pHeight">an int param that specifies the requested height of the image</param>
        /// <param name="pWidth">an int param that specifies the requested width of the image</param>
        /// <returns></returns>
        Image RetrieveImage(String pKey, int pHeight, int pWidth);
        

        



    }
}
