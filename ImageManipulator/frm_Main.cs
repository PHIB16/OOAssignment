//Author: Bradley Phipps
using System;
using System.Windows.Forms;

namespace ImageManipulator
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            //Open file dialog
            FD_ImagePathSelector.ShowDialog();
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
