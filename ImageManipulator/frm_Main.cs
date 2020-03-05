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
        //
        private IModel _model;

        public frm_Main(IModel pModel)
        {
            InitializeComponent();
            _model = pModel;
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            //Open file dialog


            if (FD_ImagePathSelector.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = FD_ImagePathSelector.FileNames;

                _Keys = _model.load(filePaths);

                pb_ImageDisplay.Image = _model.getImage(_Keys[Index].ToString(),pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            //add users selecttion to list if its a valid selection - should be in different class/ delegate?

        }

        private void btn_PreviousImage_Click(object sender, EventArgs e)
        {
            //Call delegate to display previous image index in dictionary 
            if (Index != 0 )
            {
                pb_ImageDisplay.Image = _model.getImage(_Keys[Index -= 1], pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            
        }

        private void btn_NextImage_Click(object sender, EventArgs e)
        {
            if (Index >= _Keys.Count)
            {
                Index = 0;
                pb_ImageDisplay.Image = _model.getImage(_Keys[Index + 1], pb_ImageDisplay.Width, pb_ImageDisplay.Height);
            }
            
        }
    }
}
