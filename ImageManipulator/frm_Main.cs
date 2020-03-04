//Author: Bradley Phipps
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageManipulator
{
    public partial class frm_Main : Form
    {
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

                _model.load(filePaths);
            }
            //add users selecttion to list if its a valid selection - should be in different class/ delegate?

        }

        private void btn_PreviousImage_Click(object sender, EventArgs e)
        {
            //Call delegate to display previous image index in dictionary 
        }

        private void btn_NextImage_Click(object sender, EventArgs e)
        {
            //Call delegate to display next image index in dictionary 
        }
    }
}
