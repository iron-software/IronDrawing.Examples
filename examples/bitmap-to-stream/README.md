***Based on <https://ironsoftware.com/examples/bitmap-to-stream/>***

AnyBitmap, whether created programmatically or accessed from a local file directory, can be transformed into a memory stream. This allows you to use the bitmap data directly in your program without the need for intermediate storage such as temporary buffers or files. Below is an easy-to-follow example detailing how to retrieve and convert an AnyBitmap file from your local directory into a memory stream.

## Retrieve Stream

This method is used to acquire a stream directly from an `AnyBitmap` file. All you need to do is define a `MemoryStream` variable to capture the memory stream obtained from the `AnyBitmap` leveraging the `.GetStream()` method.

## Convert to Stream

This process involves converting an `AnyBitmap` file into a memory stream. Simply initialize a `MemoryStream` variable to hold the data once the `AnyBitmap` has been converted to a memory stream with the `.ToStream()` method.