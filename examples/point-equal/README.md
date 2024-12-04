***Based on <https://ironsoftware.com/examples/point-equal/>***

One feature of the `Point` and `PointF` classes is the `Equals()` method. This function compares the x and y coordinates of two points and returns a boolean indicating whether they are equal.

In the given code example, the `Equals()` method is utilized to compare two distinct points. As a member of the `Point` class, this method is accessed using a `Point` object and requires another `Point` object as the parameter for comparison. It specifically checks for equality in the x and y coordinates of the two points in question.

It is crucial to remember that the `Equals()` method is only applicable to `Point` objects within the same class. Trying to employ this method to contrast points from different classes, such as `Point` and `PointF`, will lead to a `NullReferenceException` during execution.