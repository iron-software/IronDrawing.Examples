***Based on <https://ironsoftware.com/examples/point-pointf/>***

IronDrawing has introduced two innovative classes: `IronSoftware.Drawing.Point` and `IronSoftware.Drawing.PointF`. These classes serve to represent a pair of coordinates (double-x and double-y) in a two-dimensional space, making them essential for tasks in image processing. Similar functionalities can be found in other libraries like `System.Drawing`, `SixLabors.ImageSharp`, `SkiaSharp`, and `Microsoft.Maui.Graphics`. The main distinction between the `Point` and `PointF` classes is in the type of data they accept in their constructors.

Creating a new instance of `Point` or `PointF` is uncomplicated, involving the initialization of just two values: the X and Y coordinates.

In the provided code example, `System.Double` values are utilized to assign the x and y coordinates for a `Point` object. Conversely, `System.Single` values (floating-point values) are employed for setting similar properties in the `PointF` object.

Both the `IronSoftware.Drawing.Point` and `IronSoftware.Drawing.PointF` classes offer identical features and functions. While `System.Double`, a 64-bit floating-point type, is typically favored for its enhanced accuracy and ability to handle larger decimals, `System.Single` represents a 32-bit type with reduced precision. Therefore, it is advisable to opt for `IronSoftware.Drawing.Point` over `IronSoftware.Drawing.PointF` for higher precision needs.