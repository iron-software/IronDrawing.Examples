***Based on <https://ironsoftware.com/examples/point-offset/>***

The `Offset()` method is included in both the `Point` and `PointF` classes. It is primarily utilized for dynamically shifting or modifying the coordinates of a specific point. When the `Offset()` method is applied, it alters the existing x and y coordinates of a point and does not generate a new `Point` object.

To employ the `Offset()` method, simply invoke it by passing two integers as arguments on a `Point` or `PointF` object. The first integer will change the x coordinate of the Point, and the second one will adjust the y-coordinate. It's important to note that this method can handle both positive and negative values for these adjustments.

In the provided example, a `PointF` object is first created with specified x and y coordinates. Subsequently, the `Offset()` method is applied using both a negative and a positive integer. If needed, you can confirm the final coordinates of the point by outputting the `X` and `Y` properties of the `PointF` object to the console.