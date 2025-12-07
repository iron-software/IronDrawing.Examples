***Based on <https://ironsoftware.com/examples/rectangle-rectanglef/>***

The `IronSoftware.Drawing.Rectangle` and `IronSoftware.Drawing.RectangleF` classes from IronDrawing are designed to create rectangles using specific coordinates. Both classes utilize four parameters to define the rectangle's position and size.

The `x` and `y` parameters are used to specify the upper-left corner of the rectangle. The `Rectangle` class requires these coordinates to be of `int` type, whereas the `RectangleF` class accepts `float` types for more precision. The remaining parameters, `width` and `height`, follow the data type of the `x` and `y` coordinates respectively. Both classes measure these dimensions in pixels by default.