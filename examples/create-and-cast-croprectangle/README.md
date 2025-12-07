***Based on <https://ironsoftware.com/examples/create-and-cast-croprectangle/>***

`Rectangle` and `RectangleF` are integral components of IronDrawing, allowing you to crop images effectively. These can be seamlessly integrated by converting instances from `System.Drawing.Rectangle` or `System.Drawing.RectangleF` to `IronSoftware.Drawing.Rectangle` or `IronSoftware.Drawing.RectangleF` through the use of the `Cast` method.

## Utilizing `Rectangle` & `RectangleF`

To utilize a `Rectangle`, simply instantiate a new object while specifying the X and Y coordinates, along with the width and height in pixels. Here’s how you can create a `Rectangle`:

```csharp
// Example of initializing a Rectangle
var myRectangle = new Rectangle(x, y, width, height);
```

In a similar manner, initializing a `RectangleF` object is straightforward:

```csharp
// Example of initializing a RectangleF
var myRectangleF = new RectangleF(x, y, width, height);
```

## Conversion of `Rectangle` & `RectangleF`

Converting a `System.Drawing.Rectangle` to an `IronSoftware.Drawing.Rectangle` or a `System.Drawing.RectangleF` to an `IronSoftware.Drawing.RectangleF` can be accomplished through implicit conversion like so:

```csharp
// Example of implicit conversion from System.Drawing.Rectangle to IronSoftware.Drawing.Rectangle
IronSoftware.Drawing.Rectangle ironRect = systemRect;

// Example of implicit conversion from System.Drawing.RectangleF to IronSoftware.Drawing.RectangleF
IronSoftware.Drawing.RectangleF ironRectF = systemRectF;
```

This streamlined process allows for the easy integration of these shapes within the features of IronDrawing.