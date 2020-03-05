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
        private MemoryStream inStream;
        private MemoryStream outStream;
        private ImageFactory imageFactory;

        private byte[] photoBytes;
        public Image ScaleImage(string pKey, int pWidth, int pHeight)
        {
            
            //Image imgToReturn;
            Size size = new Size(pWidth, pHeight);

            photoBytes = File.ReadAllBytes(pKey);

            outStream = new MemoryStream();
            //        // Initialize the ImageFactory using the overload to preserve EXIF metadata.
            //        using (imageFactory = new ImageFactory(preserveExifData: true))
            //        {
            //    // Load, resize, set the format and quality and save an image.
            //    return imageFactory.Load(pImage)
            //            .Resize(size)
            //            .Image;

            //Size size = new Size(100, 100);

            using (inStream = new MemoryStream(photoBytes))
            {
                using (outStream)
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    .Resize(size)
                                    .Save(outStream);


                    }
                    // Do something with the stream.
                    return Image.FromStream(outStream);
                }
            }
        }     
                
        }
    }
