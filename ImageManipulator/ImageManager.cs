//Author: Bradley Phipps & Oliver Rooney
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
    class ImageManager: IImageData, IImageStorage
    {

        //A private dictionary variable, called _ImageDict - Stores a string filepath as the key and a .net image as the value 

        private IDictionary<string, Image> _imageDict;
        private IImageFactory _imageFact;
        private IImageProcessor _imgageProcessor;

        public ImageManager(IDictionary<string, Image> pDict, IImageFactory pImageFactory, IImageProcessor pProcesssor)
        {
            _imageFact = pImageFactory;
            _imgageProcessor = pProcesssor;
            _imageDict = pDict;
        }

        public void AddImage(string pKey)
        {
            _imageDict.Add(pKey, _imageFact.CreateImage(pKey));
            
        }

        public void AddImage(IList<string> pKeys)
        {
            foreach (string Key in pKeys)
            {
                _imageDict.Add(Key, _imageFact.CreateImage(Key));
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


        public Image RetrieveImage(string Key)
        {
            return _imageDict[Key];
        }

        public Image RetrieveImage(string Key, int pHeight, int pWidth)
        {
            return _imgageProcessor.ScaleImage(_imageDict[Key], pHeight, pWidth);
        }
    }
}
