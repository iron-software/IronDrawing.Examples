***Based on <https://ironsoftware.com/examples/point-equal/>***

Among the features provided by the `Point` and `PointF` classes is the `Equals()` method. This function compares two points by evaluating their x and y coordinates, returning a boolean result to indicate whether the points are identical.

It is crucial to recognize that this method should only be applied to `Point` instances that belong to the same class. If you try to compare points across different classes, such as a `Point` and a `PointF`, a `NullReferenceException` will be thrown during execution.