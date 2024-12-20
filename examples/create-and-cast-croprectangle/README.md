***Based on <https://ironsoftware.com/examples/create-and-cast-croprectangle/>***

`Rectangle` and `RectangleF` are incredibly useful features provided by IronDrawing, enabling users to crop image files efficiently. For those already working with rectangles from `System.Drawing.Rectangle` or `System.Drawing.RectangleF`, conversion to `IronSoftware.Drawing.Rectangle` and `IronSoftware.Drawing.RectangleF` is seamless using the `Cast` method.

## Creating `Rectangle` & `RectangleF`

To initiate a `Rectangle`, simply create an instance with specific coordinates and dimensions. For example, a new `Rectangle` can be initialized with `Rectangle(10, 10, 50, 50)`, specifying the X and Y coordinates along with width and height in pixels.
Similarly, to create a `RectangleF` object, use the constructor as shown: `RectangleF(10.2F, 16.5F, 150F, 60F)`.

## Casting `Rectangle` & `RectangleF`

To convert from `System.Drawing.Rectangle` to `IronSoftware.Drawing.Rectangle` or from `System.Drawing.RectangleF` to `IronSoftware.Drawing.RectangleF`, assign an existing instance of `System.Drawing.Rectangle` or `System.Drawing.RectangleF` to a new variable of the corresponding IronSoftware type.