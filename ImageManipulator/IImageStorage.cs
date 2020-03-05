using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public interface IImageStorage
    {
        void AddImage(String Key);

        void AddImage(IList<string> pathfilenames);

        void RemoveImage(String Key);
       
    }
}
