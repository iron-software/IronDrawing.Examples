***Based on <https://ironsoftware.com/examples/create-color/>***

`IronDrawing` offers users the flexibility to craft unique colors through several methods, including Hexadecimal, RGB values, or by selecting from an enumeration of predefined colors.

## Creating Colors

For crafting a color with a Hexadecimal value, begin by defining a variable of type `Color` and then initialize it using the `new Color("#191919")` format, where the string represents the Hexadecimal code. When using RGB values, input the specific values like so: `new Color(255, 255, 0)` to initialize a `Color` variable with these settings.

## Transitioning from `System.Drawing.Color` to `IronSoftware.Drawing.Color`

Start by setting a `System.Drawing.Color` variable to an existing color such as `System.Drawing.Color.Red`. Then, transfer this value to a new `IronSoftware.Drawing.Color` variable, which allows you to access and manipulate the `ARGB` values of the color you've just created.

## Measuring Luminance

To evaluate the luminance of an `IronSoftware.Drawing.Color` object—including those converted from `System.Drawing.Color`—apply the `.GetLuminance()` method. The luminance scale ranges from 0 (pure black) to 100 (pure white), with 50 representing a balanced mid-gray perception.