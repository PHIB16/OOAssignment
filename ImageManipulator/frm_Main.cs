//Author: Bradley Phipps
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageManipulator
{
    public partial class frm_Main : Form
    {
        private IList<String> _Keys = new List<String>();

        private int Index = 0;
        
        private IModel _model;

        public frm_Main(IModel pModel)
        {
            InitializeComponent();
            _model = pModel;
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            //If user selects 'ok' on the selectfile dialog window
            if (FD_ImagePathSelector.ShowDialog() == DialogResult.OK)
            {
                //Temp string array called filePaths that stores the filepaths of the selected images.
                string[] filePaths = FD_ImagePathSelector.FileNames;
                // Set the keys Ilist equal to the return value of the _model.load method - which stores the images into the dictionary in ImageManager
                _Keys = _model.load(filePaths);

                pb_ImageDisplay.Image = _model.getImage(_Keys[Index].ToString(),pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            //add users selecttion to list if its a valid selection - should be in different class/ delegate?

        }

        private void btn_PreviousImage_Click(object sender, EventArgs e)
        {
            Index--;
            //Call delegate to display previous image index in dictionary 
            if (Index >= 0 )
            {
                pb_ImageDisplay.Image = _model.getImage(_Keys[Index], pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            else
            {
                Index = 0;
            }
            
        }

        private void btn_NextImage_Click(object sender, EventArgs e)
        {
            Index++;

            if (Index >= _Keys.Count)
            {
                Index = 0;
                pb_ImageDisplay.Image = _model.getImage(_Keys[Index], pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            else
            {

                pb_ImageDisplay.Image = _model.getImage(_Keys[Index], pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            
        }
    }
}
