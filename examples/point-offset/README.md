***Based on <https://ironsoftware.com/examples/point-offset/>***

The `Offset()` method is found in the `Point` and `PointF` classes and is primarily employed to programmatically shift or alter the coordinates of a given point. By invoking the `Offset()` method, the existing x and y coordinates are adjusted without creating a new `Point` instance.

To apply the `Offset()` method, invoke it by providing two integers as parameters on a `Point` or **`PointF`** object. The initial parameter modifies the x coordinate of the `Point`, and the second adjusts its y-coordinate. It's important to note that negative values can also be passed as arguments.

In the provided code example, a `PointF` instance is created with predefined x and y coordinates. Subsequently, the `Offset()` method is utilized with both a negative and a positive value. If desired, the updated x and y coordinates of this `PointF` can be verified by outputting the `X` and `Y` values to the console.