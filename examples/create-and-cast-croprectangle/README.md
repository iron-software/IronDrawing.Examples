***Based on <https://ironsoftware.com/examples/create-and-cast-croprectangle/>***

`Rectangle` and `RectangleF` are powerful tools provided by IronDrawing, catering to those who need to crop images in their applications. Users already familiar with `System.Drawing.Rectangle` and `System.Drawing.RectangleF` will find it straightforward to convert these to `IronSoftware.Drawing.Rectangle` and `IronSoftware.Drawing.RectangleF` using the `Cast` method.

## Constructing `Rectangle` & `RectangleF`

To construct a `Rectangle`, simply initialize it by specifying the X and Y coordinates, along with the rectangle's width and height in pixels, such as `Rectangle(10, 10, 50, 50)`.
Similarly, for creating a `RectangleF`, you might use: `RectangleF(10.2F, 16.5F, 150F, 60F)`.

## Converting `Rectangle` & `RectangleF`

To convert an existing `System.Drawing.Rectangle` into an `IronSoftware.Drawing.Rectangle`, or a `System.Drawing.RectangleF` into an `IronSoftware.Drawing.RectangleF`, just assign a newly instantiated `System.Drawing.Rectangle` or `System.Drawing.RectangleF` to a variable declared as `IronSoftware.Drawing.Rectangle` or `IronSoftware.Drawing.RectangleF`, respectively.