using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageManipulator
{
    class ImageLoad : IModel
    {
        private IDictionary<String, Image> Images = new Dictionary<string, Image>();


        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimentsions of the visual container (ie frame) it will be viewed in.
        /// </summary>
        /// <param name="key">the unique identifier for the image to be returned</param>
        /// <param name="frameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="frameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image pointed identified by key</returns>
        public Image getImage(string key, int frameWidth, int frameHeight)
        {
            //Load image from filepath in dictionary using key

            //Scale to frameWidt/Height

            //return image

            throw new NotImplementedException();
        }

        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the 'Model'
        /// </summary>
        /// <param name="pathfilenames">a vector of strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        public IList<string> load(IList<string> pathfilenames)
        {
            //Puts passed in list of file paths into the dictionary

            //Returns a list of keys in the dictionary

            throw new NotImplementedException();
        }




    }
}
