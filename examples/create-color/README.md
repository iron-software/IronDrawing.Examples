***Based on <https://ironsoftware.com/examples/create-color/>***

IronDrawing offers flexible methods for crafting custom colors, including options to use Hexadecimal, RGB values, or select from a predefined palette through an Enum.

## Generating Colors

To define a color via Hexadecimal, instantiate a `Color` variable and assign it a string representation of the hex code, like so: `new Color("#191919")`. For RGB, input the respective values into `new Color(255, 255, 0)` and assign this to a variable of type `Color`.

## Conversion from `System.Drawing.Color` to `IronSoftware.Drawing.Color`

Start with a `System.Drawing.Color` variable, set to a predefined color such as `System.Drawing.Color.Red`. Then, transfer this value to a new `IronSoftware.Drawing.Color` variable. You can also extract and inspect the `ARGB` values from the converted color.

## Calculating Luminance

To measure the luminance of any color from the `IronSoftware.Drawing.Color` class, apply the `.GetLuminance()` method. Luminance readings range from 0, indicating black, to 100, denoting white, with 50 representing the perceptual midpoint, or "middle gray".