//Author: Bradley Phipps & Oliver Rooney
using ImageProcessor;
using System.Drawing;
using System.IO;

namespace ImageManipulator
{
    /// <summary>
    /// The implementation of IIMageProcessor, a facade for the imageprocessor library, this currently allows for the scaling of an image using imageprocessor
    /// </summary>
    public class ImageProcessor : IImageProcessor
    {
        //private field of type MemoryStream, called _outStream
        private MemoryStream _outStream;
        //private field of type IMageFactory, called _imageFactory
        private ImageFactory _imageFactory;
        
        /// <summary>
        /// Takes an image object and then resizes it to the specified scale
        /// </summary>
        /// <param name="pImage">The image object to scale</param>
        /// <param name="pWidth">The requested width of the image</param>
        /// <param name="pHeight">The requested height of the image</param>
        /// <returns>The scaled .net image</returns>
        public Image ScaleImage(Image pImage, int pWidth, int pHeight)
        {
            // Following code adapted from: https://imageprocessor.org/imageprocessor/imagefactory/

            //instance variable of type Size, called size
            Size size = new Size(pWidth, pHeight);
            //Initialise outStream as new memorystream
            _outStream = new MemoryStream();
            
                using (_outStream)
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (_imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load/ resize then save to outstream.
                        _imageFactory.Load(pImage)
                                    .Resize(size)
                                    .Save(_outStream);


                    }
                    //Get the image object from the outStream then return it
                    return Image.FromStream(_outStream);
                }
        }         
    }
}
