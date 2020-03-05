using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public interface IImageProcessor
    {

        Image ScaleImage(string pKey, int pWidth, int pHeight);

    }
}
