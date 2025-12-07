using IronSoftware.Drawing;
using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Quickstart
{
    public static class Section4
    {
        public static void Run()
        {
            // Create a new Font object with a specified font family, style, and size
            IronSoftware.Drawing.Font font = new IronSoftware.Drawing.Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);
            
            // Create a new instance of System.Drawing.Font
            System.Drawing.Font drawingFont = new System.Drawing.Font("Courier New", 30);
            
            try
            {
                // Attempt to cast System.Drawing.Font to IronSoftware.Drawing.Font
                // Note: This cast may not be directly possible if the libraries do not support each other;
                // additional conversion logic might be required.
                IronSoftware.Drawing.Font ironFont = new IronSoftware.Drawing.Font(drawingFont.FontFamily.Name, drawingFont.Style, drawingFont.Size);
            
                // Accessing properties of the IronSoftware.Drawing.Font object
                string familyName = ironFont.FamilyName; // Get the font family name
                FontStyle style = ironFont.Style;       // Get the combined font style (italic, bold, etc.)
                float size = ironFont.Size;             // Get the font size
                bool isItalic = ironFont.Italic;        // Determine if the font style includes Italic
                bool isBold = ironFont.Bold;            // Determine if the font style includes Bold
            
                // Output the font properties to verify correctness
                Console.WriteLine($"Family: {familyName}, Style: {style}, Size: {size}, Italic: {isItalic}, Bold: {isBold}");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("The conversion between System.Drawing.Font and IronSoftware.Drawing.Font is not directly supported.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}