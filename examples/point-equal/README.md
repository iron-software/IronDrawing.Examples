***Based on <https://ironsoftware.com/examples/point-equal/>***

The `Point` and `PointF` classes each include an `Equals()` method for comparing two points based on their x and y coordinates, returning a boolean result to indicate equality.

In the provided example, the `Equals()` method is utilized to assess whether two points are identical. This method must be invoked on an instance of the `Point` class, and it requires another `Point` instance as an argument for comparison. This function strictly evaluates the x and y coordinates between two points to determine equality.

It's crucial to understand that the `Equals()` method should only be employed with objects that are instances of the same class. Trying to compare objects from the `Point` class to those from the `PointF` class using this method will trigger a `NullReferenceException` at runtime, as these are considered objects of different classes.