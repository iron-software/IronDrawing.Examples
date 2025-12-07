***Based on <https://ironsoftware.com/examples/get-color-depth/>***

Color depth is quantified in bits per pixel (bpp), which describes the color information of the components. This measure might refer to the bits allocated for a single pixel's color or how many bits are designated for each color component in a pixel. Furthermore, bpp is useful for assessing image quality, with a higher bpp usually suggesting better image definition.

To read an image from a file, utilize the `AnyBitmap.FromFile("FILE_PATH")` method. After loading the image, access its bpp by calling `.BitsPerPixel` on the `AnyBitmap` object to retrieve the image’s color depth.