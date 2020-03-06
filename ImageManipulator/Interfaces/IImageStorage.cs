//Author: Bradley Phipps & Oliver Rooney
using System;
using System.Collections.Generic;

namespace ImageManipulator
{

    /// <summary>
    /// Interface for ImageManager, this deals with the storage functions such as adding and removing images from the collection - seperate from the other interface to adhere to interface segregation
    /// </summary>
    public interface IImageStorage
    {
        /// <summary>
        /// Adds an image to the image dictionary, based on the key thats passed in (filepath)
        /// </summary>
        /// <param name="Key">The filepath of the image to be added to the collection</param>
        void AddImage(String Key);

        /// <summary>
        /// Adds an image to the image dictionary, based on a list of keys passed in (filepath)
        /// </summary>
        /// <param name="pathfilenames">list of filenames to be used as keys</param>
        void AddImage(IList<string> pathfilenames);
        
       
    }
}
