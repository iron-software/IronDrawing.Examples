***Based on <https://ironsoftware.com/examples/create-and-cast-fonts/>***

## Creating and Converting Fonts

IronDrawing provides the capability for users to generate new fonts for use within their applications. Additionally, it offers the convenience of converting an existing `System.Drawing.Font` to `IronSoftware.Drawing.Font` by using a straightforward casting process.

## Generating Fonts

To generate new fonts, users need to initialize a `System.Drawing.Font` object and specify the font family, style, and size. For example, creating a `Font` like `Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30)` will result in a 30-pixel, Times New Roman font styled with both bold and italic features.

## Converting Fonts

For converting a font from `System.Drawing.Font`, simply assign the created font to a variable designated as `IronSoftware.Drawing.Font`. This method seamlessly integrates `System.Drawing` fonts into the IronSoftware.Drawing framework for enhanced usability and compatibility.