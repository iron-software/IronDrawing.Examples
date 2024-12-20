***Based on <https://ironsoftware.com/examples/bitmap-to-stream/>***

AnyBitmap files, whether created programmatically or accessed from a local file system, can be transformed into memory streams. This technique eliminates the need for creating temporary files or buffers within the application. In the following code example, we illustrate an uncomplicated method to both retrieve a stream and convert an AnyBitmap file from a local directory into a memory stream.

## Retrieve Stream

Use this function to extract the stream from a specific `AnyBitmap` file. Initiate by assigning a `MemoryStream` variable that will hold the memory stream obtained from the `AnyBitmap` file using the `.GetStream()` method.

## Convert to Stream

This function facilitates the conversion of an `AnyBitmap` file into a memory stream. Start by declaring a `MemoryStream` variable to capture the data from the `AnyBitmap` file, which is converted into a memory stream using the `.ToStream()` method.