//Author: Bradley Phipps & Oliver Rooney
using ImageManipulator;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulator
{
    /// <summary>
    /// The controller class removes the responsibility of running the application from the program.cs class, this means that components can be injected where needed before the application is ran.
    /// </summary>
    public class Controller
    {
        // A private field of type IImageFactory, called _imageFactory
        private IImageFactory _imageFactory = new ImgFactory();
        // A private field of type IImageProcessor, called _imageProcessor
        private IImageProcessor _imageProcessor = new ImageProcessor();
        //a private field of type IImageStorage, called _imageMgr
        private IImageStorage _imageMgr;
        //A private field of type IModel, called _model
        private IModel _model;
        //A private field of type IDictionary, called _imageDict
        private IDictionary<string,Image> _imageDict = new Dictionary<string, Image>();


        public Controller()
        {
            //instantiate the _imageMgr field, passing in the _imageProcessor and _imageFactory as parameters - dependency injection
            _imageMgr = new ImageManager(_imageDict, _imageFactory, _imageProcessor);
            //Instantiate _model, passing in the _imageMgr - dependency injection
            _model = new Model(_imageMgr);
            

        }

        public IModel GetModel()
        {
            return _model;
        }
            
    }

}


