//Author: Bradley Phipps & Oliver Rooney

using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public class ImageProcessor : IImageProcessor
    {
       
        private MemoryStream outStream;
        private ImageFactory imageFactory;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pImage"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <returns></returns>
        public Image ScaleImage(Image pImage, int pWidth, int pHeight)
        {
            
            //Image imgToReturn;
            Size size = new Size(pWidth, pHeight);

            outStream = new MemoryStream();

                using (outStream)
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(pImage)
                                    .Resize(size)
                                    .Save(outStream);


                    }
                    // Do something with the stream.
                    return Image.FromStream(outStream);
                }
        }         
    }
}
