***Based on <https://ironsoftware.com/examples/point-gethashcode/>***

IronDrawing's `Point` and `PointF` classes feature the `GetHashCode()` method, which calculates a numerical hash code uniquely representing the identity of objects such as a `Point`. These hash codes are essential in the implementation of dictionaries, hash sets, and hash tables as they enhance the efficiency of hashing operations and object equality checks.

To retrieve the hash code for a `Point`, invoke the `GetHashCode()` method on a `Point` or `PointF` object, which will output a `System.Int32`. This output can then be utilized in further operations or simply displayed.

In addition to the `GetHashCode()` method, the `Equals()` method can be utilized to assess the equivalence of two points. While `Equals()` offers a straightforward way to compare two objects directly for equality, `GetHashCode()` is primarily used to generate a hash code that supports the functioning of various data structures, including dictionaries and hash tables.