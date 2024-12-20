***Based on <https://ironsoftware.com/examples/get-color-depth/>***

Color depth is quantified in bits per pixel (bpp), which describes the number of bits representing the color components of a single pixel or the bits allocated to each color component of a pixel. This metric also serves as an indicator of an image's quality — generally, a higher bpp value results in a more defined and clearer image.

To load an image file, the method `AnyBitmap.FromFile(@"FILE_PATH")` is utilized. After loading the image, you can retrieve the color depth by accessing the `.BitsPerPixel` attribute on the resulting `AnyBitmap` object.