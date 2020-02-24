//Author: Bradley Phipps
using System.Windows.Forms;

namespace ImageManipulator
{
    class Controller
    {
        private IModel _model = new Model();

        public Controller()
        {
            //Create things to pass into frm_main - dependency injection
            



        Application.Run(new frm_Main(_model));

        }
            
    }

}


