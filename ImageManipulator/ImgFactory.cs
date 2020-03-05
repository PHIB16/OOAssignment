using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    /// <summary>
    /// 
    /// </summary>
    public class ImgFactory : IImageFactory
    {
        public Image CreateImage(String pFilePath)
        {
            return Image.FromFile(pFilePath);
        }
    }
}
