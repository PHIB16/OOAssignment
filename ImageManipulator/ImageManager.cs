//Author: Bradley Phipps & Oliver Rooney
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulator
{
    /// <summary>
    /// The imageManager class is responsible for dealing with interaction with the image dictionary, such as adding images or retrieving them from it. it implements both IImageData and IImageStorage
    /// </summary>
    class ImageManager: IImageData, IImageStorage
    {

        //A private Idictionary field, called _ImageDict - Stores a string filepath as the key and a .net image as the value 
        private IDictionary<string, Image> _imageDict;
        //Private field of type IImageFactory, called _imageFact
        private IImageFactory _imageFact;
        //private field of type IImageProcessor, called _imageProcessor
        private IImageProcessor _imageProcessor;

        /// <summary>
        /// Constructor for the ImageManager class
        /// </summary>
        /// <param name="pDict">passed in dictionary to remove responsibility for creating the collection</param>
        /// <param name="pImageFactory">passed in IImageFactory, removing responsibility for creating the factory</param>
        /// <param name="pProcesssor">passed in IImageProcessor, removing responsibility for creating the processor</param>
        public ImageManager(IDictionary<string, Image> pDict, IImageFactory pImageFactory, IImageProcessor pProcesssor)
        {
            //set _imageFact equal to pImageFactory
            _imageFact = pImageFactory;
            //set _imageProcessor equal to pProcessor
            _imageProcessor = pProcesssor;
            //set _imageDict equal to pDict
            _imageDict = pDict;
        }
        /// <summary>
        /// Adds an image to the image dictionary, based on the key thats passed in (filepath)
        /// </summary>
        /// <param name="pKey">The filepath of the image to be added to the collection</param>
        public void AddImage(string pKey)
        {
            //
            _imageDict.Add(pKey, _imageFact.CreateImage(pKey));
            
        }
        
        /// <summary>
        /// Adds an image to the image dictionary, based on a list of keys passed in (filepath)
        /// </summary>
        /// <param name="pKeys">list of filenames to be used as keys</param>
        public void AddImage(IList<string> pKeys)
        {
            //Try catch for if the user tries to add duplicate keys
            try
            {
                foreach (string Key in pKeys)
                {
                
                    _imageDict.Add(Key, _imageFact.CreateImage(Key));
                }
                 
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to add selected images, they may already be loaded into the system");
                System.Console.Write(e.ToString());
            }
        }

        /* For future use
        public void RemoveImage(string Key)
        {
            throw new NotImplementedException();
        }

        public Image ReplaceImage(string Key)
        {
            throw new NotImplementedException();
        }
        */

        /// <summary>
        /// finds the value in the image dictionary based on the passed in key, this is then returned as its stored.
        /// </summary>
        /// <param name="pKey">the key value for the image dictionary, storing the image filepath</param>
        /// <returns>A .Net image object </returns>
        public Image RetrieveImage(string pKey)
        {
            // returns the value in the dictionary based on  pKey
            return _imageDict[pKey];
        }
        /// <summary>
        /// finds the value in the image dictionary based on the passed in key, this is then returned as a scaled version based on the pHeight/ pWidth params.
        /// </summary>
        /// <param name="pKey">the key value for the image dictionary, storing the image filepath</param>
        /// <param name="pHeight">an int param that specifies the requested height of the image</param>
        /// <param name="pWidth">an int param that specifies the requested width of the image</param>
        /// <returns></returns>
        public Image RetrieveImage(string pKey, int pHeight, int pWidth)
        {
            // call the imageprocessor scaleImage method 
            return _imageProcessor.ScaleImage(_imageDict[pKey], pHeight, pWidth);
        }
    }
}
