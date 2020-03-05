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
    public interface IImageFactory
    {
       Image CreateImage(String pFilePath);


    }
}
