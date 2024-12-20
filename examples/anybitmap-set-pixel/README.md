***Based on <https://ironsoftware.com/examples/anybitmap-set-pixel/>***

The `SetPixel()` function in the `AnyBitmap` class enables users to customize individual pixels of an image by assigning specific colors to them. This functionality is particularly beneficial for tasks such as drawing lines or adding color enhancements to images.

Located within the `AnyBitmap` class of the `IronSoftware.Drawing` namespace, the `SetPixel()` method requires three arguments: the x-coordinate, the y-coordinate, and a color object described by `IronSoftware.Drawing.Color`. To use this method, one must invoke it on an instance of `AnyBitmap`, targeting the desired pixel within the image associated with that `AnyBitmap` instance.

Consider the following example where the `AnyBitmap.FromFile()` method is used to load an image into a `AnyBitmap` object. A simple for loop iterates to draw a straight, horizontal line by modifying the x-coordinate with a specified color on the bitmap. After the modifications, the resultant image is saved under a new file name. Here’s how it's executed in code:

```csharp
// Load the image from a file
AnyBitmap image = AnyBitmap.FromFile("path/to/your/image.jpg");

// Draw a horizontal line across the image
for (int x = 0; x < image.Width; x++) {
    image.SetPixel(x, 10, Color.Red); // Setting pixel color to red at y=10
}

// Save the modified image
image.Save("path/to/your/new-image.jpg");
```

This code snippet effectively demonstrates how to utilize the `SetPixel()` method to alter specific pixels and visualize changes in an image, thereby showcasing the versatility of the `AnyBitmap` class in image manipulation tasks.