using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public interface IImageData
    {
        Image RetrieveImage(String Key);

        Image RetrieveImage(String Key, int pHeight, int pWidth);

        Image ReplaceImage(String Key);

        



    }
}
