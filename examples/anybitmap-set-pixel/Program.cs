using IronSoftware.Drawing;

AnyBitmap bitmap = AnyBitmap.FromFile(@"sample.jpg");

// Create horizontal line with magenta color
for (int i = 1157; i < 2382; i++)
{
    bitmap.SetPixel(i, 869, Color.Magenta);
}
bitmap.SaveAs("underlined.jpg");
