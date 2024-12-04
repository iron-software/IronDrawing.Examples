using IronSoftware.Drawing;
using IronSoftware.System.Drawing;
namespace irondrawing.Quickstart
{
    public class Section1
    {
        public void Run()
        {
            ​
            // Create a new AnyBitmap object
            var bitmap = AnyBitmap.FromFile("FILE_PATH");
            bitmap.SaveAs("result.jpg");
            ​
            var bytes = bitmap.ExportBytes();
            ​
            var resultExport = new System.IO.MemoryStream();
            bitmap.ExportStream(resultExport, AnyBitmap.ImageFormat.Jpeg, 100);
            ​
            // Casting between System.Drawing.Bitmap and IronSoftware.Drawing.AnyBitmap
            System.Drawing.Bitmap image = new System.Drawing.Bitmap("FILE_PATH");
            IronSoftware.Drawing.AnyBitmap anyBitmap = image;
            anyBitmap.SaveAs("result-from-casting.png");
        }
    }
}