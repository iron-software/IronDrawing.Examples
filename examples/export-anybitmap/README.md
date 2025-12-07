***Based on <https://ironsoftware.com/examples/export-anybitmap/>***

The `AnyBitmap` file created using the IronDrawing tool can be seamlessly converted to various other image formats, offering users the flexibility to determine the optimal balance between image quality and file size.

## Converting `AnyBitmap` to Other Formats

To convert an `AnyBitmap` file to a different image format, start by loading the `AnyBitmap` file and then utilize the `.ExportFile()` method. This method provides three parameters you can adjust:

1. **Exported file name**
2. **Target image format**
3. **Degree of quality reduction**

The resulting image can be saved in any of the listed formats:

- **Bmp**: Bitmap Image File
- **Gif**: Graphical Interchange Format
- **Png**: Portable Network Graphics
- **Jpeg**: Joint Photographic Experts Group
- **Tiff**: Tagged Image File Format
- **Webp**: Web Picture
- **Wbmp**: Wireless Bitmap
- **Wmf**: Windows Metafile
- **Icon**: Icon File