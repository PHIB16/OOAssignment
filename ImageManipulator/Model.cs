//Author: Bradley Phipps & Oliver Rooney

using System.Collections.Generic;
using System.Drawing;
namespace ImageManipulator
{
    /// <summary>
    /// Implementation of IModel, this is the concrete implementation of how front ends will interact with the backend ImageManager
    /// </summary>
    public class Model  : IModel 
    {
       
        //Private IImageStorage Variable, to be inititalised by dependency injection in the constructor
        private IImageStorage _imageStore;


        public Model( IImageStorage pImageStore)
        {
            //replace this with  delegates maybe for storing and loading
            _imageStore = pImageStore;

        }
        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimentsions of the visual container (ie frame) it will be viewed in.
        /// </summary>
        /// <param name="key">the unique identifier for the image to be returned</param>
        /// <param name="frameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="frameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image pointed identified by key</returns>
        public Image getImage(string key, int frameWidth, int frameHeight)
        {
            //Calls the RetrieveImage method from ImageManager by polymorphing the _imageStore into and IImageData
            return (_imageStore as IImageData).RetrieveImage(key, frameWidth, frameHeight); 
        }
        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the 'Model'
        /// </summary>
        /// <param name="pathfilenames">a vector of strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        public IList<string> load(IList<string> pathfilenames)
        {
            // maybe use a delegate for the ImageStore class which we pass in the return from the imagefactory to.
            _imageStore.AddImage(pathfilenames);

            //Returns the path names of the inmages so that the form can use them as keys for image requests etc
            return pathfilenames;
        }



    }
}
