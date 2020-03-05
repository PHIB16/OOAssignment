//Author: Bradley Phipps
using System.Windows.Forms;

namespace ImageManipulator
{
    /// <summary>
    /// 
    /// </summary>
    class Controller
    {
        private IImageFactory imageFactory = new ImgFactory();
        private IImageProcessor imageProcessor = new ImageProcessor();
        private IImageStorage imageMgr;

        private IModel _model;

        public Controller()
        {
            imageMgr = new ImageManager(imageFactory, imageProcessor);
            //Create things to pass into frm_main - dependency injection
            _model = new Model(imageFactory, imageMgr);


            Application.Run(new frm_Main(_model));

        }
            
    }

}


