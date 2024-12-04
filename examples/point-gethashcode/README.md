***Based on <https://ironsoftware.com/examples/point-gethashcode/>***

In the `Point` and `PointF` classes provided by IronDrawing, there is a useful method named `GetHashCode()`. This method assigns a numerical code that uniquely identifies an object, helping facilitate operations like object comparison in data structures such as hash sets, dictionaries, and tables.

To retrieve the hash code for a `Point` or `PointF`, simply invoke the `GetHashCode()` method on the object instance. This method returns a `System.Int32` object that you can either display or save for future use.

Below is a demo where a `PointF` instance is created with specified coordinates. Following instantiation, `GetHashCode()` is called on this object, and the resulting hash code is captured in a variable. If desired, the hash code can then be printed to the console for verification.

Both `GetHashCode()` and `Equals()` methods are integral for comparing two points, with `GetHashCode()` generating a unique identifier for a point and `Equals()` comparing the actual values. While `Equals()` gives a direct comparison result, `GetHashCode()` is generally used for generating a hash code usable in various collection frameworks, including dictionaries and hash tables.