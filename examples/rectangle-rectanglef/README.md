***Based on <https://ironsoftware.com/examples/rectangle-rectanglef/>***

IronDrawing offers two classes, `IronSoftware.Drawing.Rectangle` and `IronSoftware.Drawing.RectangleF`, designed for creating rectangles at specific coordinates on a page. These classes utilize four parameters to delineate the rectangle's position and dimensions.

The classes accept parameters for `x` and `y` coordinates, representing the top-left corner of the rectangle. The `Rectangle` class requires these coordinates as integers, while the `RectangleF` class uses floats. The subsequent parameters specify the `width` and `height` of the rectangle, using the same data types as their respective coordinate parameters. Both classes default to using pixels as the unit of measurement.