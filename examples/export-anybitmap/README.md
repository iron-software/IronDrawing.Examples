***Based on <https://ironsoftware.com/examples/export-anybitmap/>***

The `AnyBitmap` files created using the IronDrawing tool can be converted into various image formats, offering the capability to adjust the quality loss during the conversion. This feature is essential for users who need to find a perfect balance between image quality and file size.

To convert an `AnyBitmap` file into another image format, first, load the `AnyBitmap` file, then utilize the `.ExportFile()` method. This method supports three parameters, namely the **name of the exported file**, **image format**, and **extent of image quality loss**. The available formats for the exported image include:

- Bmp
- Gif
- Png
- Jpeg
- Tiff
- Webp
- Wbmp
- Wmf
- Icon

This versatility in formats ensures that users can meet various specifications and requirements for their image handling tasks.