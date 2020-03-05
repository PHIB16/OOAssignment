//Author: Bradley Phipps & Oliver Rooney
using System.Drawing;

namespace ImageManipulator
{
    /// <summary>
    /// The interface wrapper for imageprocessor functionality - currently just scaling the object
    /// </summary>
    public interface IImageProcessor
    {
        /// <summary>
        /// Takes an Image object and specified width/height and returns a newly scaled image object
        /// </summary>
        /// <param name="pImg">The image object to be scaled</param>
        /// <param name="pWidth">the requested image width</param>
        /// <param name="pHeight">the requested image height</param>
        /// <returns>The scaled image object</returns>
        Image ScaleImage(Image pImg, int pWidth, int pHeight);

    }
}
