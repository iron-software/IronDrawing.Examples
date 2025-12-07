***Based on <https://ironsoftware.com/examples/read-bytes-from-anybitmap/>***

## Manipulating `AnyBitmap` Files

The `IronDrawing` library enables users to handle `AnyBitmap` files at the byte level. This library offers comprehensive methods to **Retrieve**, **Output**, and **Load** bytes from an `AnyBitmap` file.

To initiate, load the desired image file into an `AnyBitmap` instance through the `AnyBitmap.FromFile(@"FILE_PATH")` method. This object provides several functionalities, such as retrieving the byte data with the `.GetBytes()` method. Additionally, it allows for byte exportation where users can adjust the image format and the extent of compression using `.ExportBytes(AnyBitmap.ImageFormat.Format, 10)`. To access a file's entire byte array, `File.ReadAllBytes(@"FILE_PATH")` can be utilized.