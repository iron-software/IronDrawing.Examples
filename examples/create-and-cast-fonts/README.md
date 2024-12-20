***Based on <https://ironsoftware.com/examples/create-and-cast-fonts/>***

## Creating and Converting Fonts with IronDrawing

IronDrawing allows users to design new fonts or utilize an established `System.Drawing.Font` by converting it to `IronSoftware.Drawing.Font`.

## Generating Fonts

To generate a font, users create an instance of `System.Drawing.Font` while specifying the desired family, style, and size, as shown below: `Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30)`. This code snippet crafts a Times New Roman font that is both bold and italic with a size of 30 pixels.

## Converting Fonts

For converting a `System.Drawing.Font` to an `IronSoftware.Drawing.Font`, simply assign the previously created font object to a variable of type `IronSoftware.Drawing.Font`.