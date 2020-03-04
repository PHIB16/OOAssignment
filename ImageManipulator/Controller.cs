//Author: Bradley Phipps
using System.Windows.Forms;

namespace ImageManipulator
{
    /// <summary>
    /// 
    /// </summary>
    class Controller
    {
        private IImageFactory imageFactory = new ImageFactory();
        private IImageStore imageStore = new ImageStore();

        private IModel _model;

        public Controller()
        {
            //Create things to pass into frm_main - dependency injection
            _model = new Model(imageFactory, imageStore);


            Application.Run(new frm_Main(_model));

        }
            
    }

}


