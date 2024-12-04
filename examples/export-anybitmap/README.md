***Based on <https://ironsoftware.com/examples/export-anybitmap/>***

The `AnyBitmap` files created using IronDrawing can be transformed into various image formats. This functionality also allows users to adjust the level of compression applied to the exported image, thereby optimizing between image quality and file size.

To convert an `AnyBitmap` file to another image format, first load the `AnyBitmap` file, then utilize the `.ExportFile()` method. This method provides three parameters for customization: the **name of the output file**, the **desired image format**, and the **level of image loss**. The available formats for the exported image include:

- Bmp
- Gif
- Png
- Jpeg
- Tiff
- Webp
- Wbmp
- Wmf
- Icon