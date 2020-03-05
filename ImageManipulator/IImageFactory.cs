//Author: Bradley Phipps & Oliver Rooney
using System;
using System.Drawing;

namespace ImageManipulator
{
    /// <summary>
    /// The interface for image factories. Specifies the implementation of a CreateImage method
    /// </summary>
    public interface IImageFactory
    {

        /// <summary>
        /// Creates a .NET image object using a provided filepath
        /// </summary>
        /// <param name="pFilePath">The filepath of the image that needs to be created as an image object</param>
        /// <returns>A .NET image object</returns>
       Image CreateImage(String pFilePath);
        
    }
}
