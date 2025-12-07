using System;
using IronSoftware.System.Drawing;
namespace IronDrawing.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
        {
            // The IronSoftware.Drawing library provides enhanced color manipulation features.
            // This example demonstrates creating color objects and converting between
            // System.Drawing.Color and IronSoftware.Drawing.Color.
            
            // Create a new Color object from a hex string.
            Color fromHex = Color.FromHex("#191919");
            
            // Create a new Color object from RGB values.
            Color fromRgb = Color.FromRgb(255, 255, 0);
            
            // Create a new Color object using an enumeration.
            Color fromEnum = Color.Crimson;
            
            // Casting between System.Drawing.Color and IronSoftware.Drawing.Color.
            System.Drawing.Color drawingColor = System.Drawing.Color.Red;
            
            // Convert System.Drawing.Color to IronSoftware.Drawing.Color.
            IronSoftware.Drawing.Color ironColor = Color.FromSystemColor(drawingColor);
            
            // Access the alpha, red, green, and blue components of the IronSoftware.Drawing.Color.
            byte alpha = ironColor.A;
            byte red = ironColor.R;
            byte green = ironColor.G;
            byte blue = ironColor.B;
            
            // Calculate the luminance of the color.
            // Luminance is a value from 0 (black) to 100 (white) where 50 is the perceptual "middle grey".
            double luminance = ironColor.GetLuminance();
            
            // Log the calculated attributes to the console.
            Console.WriteLine($"Color Details - ARGB: ({alpha}, {red}, {green}, {blue}), Luminance: {luminance}");
        }
    }
}