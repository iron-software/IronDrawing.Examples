***Based on <https://ironsoftware.com/examples/anybitmap-set-pixel/>***

The `SetPixel()` function within the `AnyBitmap` class allows users to alter colors of individual pixels on an image. This capability is particularly useful for tasks such as drawing or for generating simple lines on an image in a designated color.

You can locate the `SetPixel()` function within the `AnyBitmap` class under the `IronSoftware.Drawing` namespace. This function requires three arguments: the x-coordinate, the y-coordinate, and a `IronSoftware.Drawing.Color` object. By invoking this method on an instance of `AnyBitmap`, it allows for the modification of pixel colors on the image associated with that `AnyBitmap` instance.

The following code example illustrates how an image is loaded into an `AnyBitmap` object using the `AnyBitmap.FromFile()` method. A loop is then employed to generate a colored horizontal line by iterating over and modifying the x-coordinate. Following the execution of this loop, the modified bitmap is saved onto the local system under a new filename.