***Based on <https://ironsoftware.com/examples/anybitmap-set-pixel/>***

The `SetPixel()` function found within the `AnyBitmap` class of the `IronSoftware.Drawing` namespace allows you to modify individual pixels on an image by specifying their color. This functionality is particularly useful for drawing purposes, including the creation of lines on images with chosen colors.

Located within the `AnyBitmap` class in `IronSoftware.Drawing`, the `SetPixel()` accepts three arguments: the x-axis coordinate, the y-axis coordinate, and a color represented by an `IronSoftware.Drawing.Color` instance. To change the color of a pixel in an image, this method should be invoked on an existing `AnyBitmap` object.

The following code example demonstrates using the `AnyBitmap.FromFile()` method to load an image into an `AnyBitmap` object. A for-loop is then utilized to draw a horizontal colored line by altering the x coordinate. Finally, the altered bitmap is saved under a new filename on the local system.