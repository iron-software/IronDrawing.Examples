***Based on <https://ironsoftware.com/examples/point-offset/>***

The following guide will help you understand how to modify coordinates within the `PointF` or `Point` class using the `Offset()` method.

This useful method is featured in both the `Point` and `PointF` classes. Its primary function is to change the coordinates of a specific point through code. When called, the `Offset()` method alters the existing x and y coordinates directly, without the need to create a new `Point` object.

To apply the `Offset()` method, invoke it with two integer parameters on an instance of a `Point` or `PointF`. The first parameter will shift the x-coordinate by the specified value, while the second shifts the y-coordinate. It’s important to note that this method can handle both positive and negative shift values.

- **Creating a `PointF` Object**: Use the `PointF` class to craft points that require floating decimal precision for their x and y coordinates. For instance, a point might start at (10.5, 20.5).
- **Utilizing the `Offset()` Method**: Modify the `PointF` object's coordinates by the provided offsets. For example, executing `point.Offset(-5.0f, 10.0f);` would adjust the x-coordinate backward by 5.0 and the y-coordinate forward by 10.0.
- **Output to Console**: To visualize the changes, print both the original and updated coordinates of the `PointF` object to the console, showing the practical impact of the `Offset()` method.

This method is straightforward and efficient for programmatically managing point coordinates within your applications.