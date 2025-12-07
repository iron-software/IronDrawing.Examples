using System.Drawing;
using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Quickstart
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new AnyBitmap object from a file
            // Replace "FILE_PATH" with the actual path of the image you want to process
            var bitmap = AnyBitmap.FromFile("FILE_PATH");
            
            // Save the AnyBitmap object as a JPEG file
            bitmap.SaveAs("result.jpg");
            
            // Export the AnyBitmap as a byte array
            // This can be useful if you want to send the image data over a network or save it in a database
            var bytes = bitmap.ExportBytes();
            
            // Create a memory stream to export the AnyBitmap as a JPEG stream with 100% quality
            using (var resultExport = new MemoryStream())
            {
                // This exports the image to the stream with the specified format and quality
                bitmap.ExportStream(resultExport, AnyBitmap.ImageFormat.Jpeg, 100);
                // Be sure to use 'using' or manually close the stream to release resources
            }
            
            // Casting between System.Drawing.Bitmap and IronSoftware.Drawing.AnyBitmap
            // Load a System.Drawing.Bitmap from the same file
            System.Drawing.Bitmap image = new System.Drawing.Bitmap("FILE_PATH");
            
            // This is an implicit conversion from System.Drawing.Bitmap to IronSoftware.Drawing.AnyBitmap
            // This step is necessary if you are working with System.Drawing.Bitmap and need to convert to IronSoftware.Drawing.AnyBitmap for processing
            IronSoftware.Drawing.AnyBitmap anyBitmap = AnyBitmap.FromBitmap(image);
            
            // Save the resulting AnyBitmap from casting as a PNG file
            anyBitmap.SaveAs("result-from-casting.png");
        }
    }
}