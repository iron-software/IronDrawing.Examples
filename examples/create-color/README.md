***Based on <https://ironsoftware.com/examples/create-color/>***

IronDrawing offers several methods for users to create custom colors, including using Hexadecimal, RGB values, or selecting from a predefined Enum of available colors.

## Creating Colors

You can generate a color by specifying its Hexadecimal code. Simply declare a variable of type `Color` and set it using the `new Color("#191919")` constructor. Alternatively, for RGB color creation, input the RGB values like this: `new Color(255, 255, 0)`, and store these in a variable of type `Color`.

## Converting `System.Drawing.Color` to `IronSoftware.Drawing.Color`

Begin by creating a `System.Drawing.Color` variable and initialise it with a color, for example, `System.Drawing.Color.Red`. You can then assign this to a new `IronSoftware.Drawing.Color` variable. The ARGB values from the original color are retained and can be accessed after the assignment.

## Calculating Luminance

To determine the luminance of any `IronSoftware.Drawing.Color`, including those converted from `System.Drawing.Color`, use the `.GetLuminance()` method. Luminance measures brightness on a scale from 0 (black) to 100 (white), with 50 representing a mid-level gray.