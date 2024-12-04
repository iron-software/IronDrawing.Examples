using IronSoftware.Drawing;
using System.IO;

// Get, export, and read bytes
AnyBitmap bitmap = AnyBitmap.FromFile(@"FILE_PATH");
byte[] bit = bitmap.GetBytes(); // Get
byte[] export = bitmap.ExportBytes(AnyBitmap.ImageFormat.Tiff, 10);  // Export
byte[] bat = File.ReadAllBytes("file_path"); // Read


