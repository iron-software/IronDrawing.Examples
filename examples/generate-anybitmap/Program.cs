using IronSoftware.Drawing;
using System;
using System.IO;

AnyBitmap bitmap;

// Generate AnyBitmap using filepath
bitmap = AnyBitmap.FromFile(@"FILE_PATH");
bitmap.SaveAs("output.bmp");

// Generate AnyBitmap from bytes
byte[] bytes = File.ReadAllBytes(@"FILE_PATH");
bitmap = AnyBitmap.FromBytes(bytes);
bitmap.SaveAs("result.bmp");

// Generate AnyBitmap from memory stream
byte[] bytes2 = File.ReadAllBytes(@"FILE_PATH");
MemoryStream ms = new MemoryStream(bytes2);
bitmap = AnyBitmap.FromStream(ms);
bitmap.SaveAs("output.bmp");

// Generate AnyBitmap from Uri
Uri uri = new Uri("URI_PATH");
bitmap = await AnyBitmap.FromUriAsync(uri);
bitmap.SaveAs("uriImage.bmp");

// Generate AnyBitmap file from SVG file
bitmap = AnyBitmap.FromFile(@"FILE_PATH.svg");
bitmap.SaveAs("result.jpg");


