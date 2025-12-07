***Based on <https://ironsoftware.com/examples/point-pointf/>***

IronDrawing has introduced two new classes: `IronSoftware.Drawing.Point` and `IronSoftware.Drawing.PointF`. These classes are crucial for representing coordinates as an ordered pair of x and y values in a two-dimensional space, greatly facilitating image manipulation tasks. Other libraries, such as `System.Drawing`, `SixLabors.ImageSharp`, `SkiaSharp`, and `Microsoft.Maui.Graphics`, offer similar classes, yet the distinction between IronDrawing's `Point` and `PointF` lies in the data types they accommodate in their constructors.

Creating instances of `Point` or `PointF` is simple and requires setting two main properties:

- `Point` objects are created by specifying the coordinates using `System.Double` for both `x` and `y` properties.
- Conversely, `PointF` objects utilize `System.Single` values (floats) for the same purpose.

Both `IronSoftware.Drawing.Point` and `IronSoftware.Drawing.PointF` provide identical functionalities and methods. However, using `System.Double` is generally preferred for its enhanced accuracy and ability to handle larger decimal values, being a 64-bit double precision floating-point type. In contrast, `System.Single` is a 32-bit type and offers less precision, making `IronSoftware.Drawing.Point` the more advisable choice for most precise applications.