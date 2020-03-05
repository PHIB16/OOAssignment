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
    public class Model  : IModel 
    {
        //
        private IImageFactory _imageFactory;

        private IImageStorage _imageStore;


        public Model(IImageFactory pImageFactory, IImageStorage pImageStore)
        {

            //use for getImage, will send back an image thats the right size
            _imageFactory = pImageFactory;

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
            

            return (_imageStore as IImageData).RetrieveImage(key, frameWidth, frameHeight); ;
        }
        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the 'Model'
        /// </summary>
        /// <param name="pathfilenames">a vector of strings; each string containing path/filename for an image file to be loaded</pa+ram>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        public IList<string> load(IList<string> pathfilenames)
        {
            // maybe use a delegate for the ImageStore class which we pass in the return from the imagefactory to.
            _imageStore.AddImage(pathfilenames);

            return pathfilenames;
        }



    }
}
