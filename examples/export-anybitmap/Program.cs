using IronSoftware.Drawing;

//Export AnyBitmap files to other formats with ability to control loss
AnyBitmap bitmap = new AnyBitmap(@"FILE_PATH");
bitmap.ExportFile("losslogo.png", AnyBitmap.ImageFormat.Png, 100);


