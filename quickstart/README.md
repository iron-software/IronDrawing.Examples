# Replace `System.Drawing.Common` with IronDrawing in .NET Projects

> Docs: [IronDrawing documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/)


## Discover IronDrawing: Your Open-Source Solution Across All .NET Platforms

**IronDrawing** is an open-source library from Iron Software that replaces `System.Drawing.Common` in .NET projects on Windows, macOS, and Linux.

Creating class libraries and NuGet packages that handle graphics, images, and fonts across .NET 5, 6, 7, & 8 should be straightforward and efficient.

IronDrawing integrates flawlessly with the evolving .NET graphics standards starting from .NET 5 to .NET 8, allowing developers to focus on their preferred environment without hassle.

<div class="content-img-align-center">
  <div class="center-image-wrapper">
    <img src="https://ironsoftware.com/static-assets/drawing/irondrawing-get-started.webp" alt="IronDrawing: open-source drawing types for .NET" class="img-responsive add-shadow" width="645" height="618">
  </div>
</div>

### Overview

The .NET framework by Microsoft, adopted by countless developers globally, has introduced a significant change: `System.Drawing.Common` is now restricted to Windows only.

This adaptation poses challenges for developers managing cross-platform libraries that depend on `System.Drawing.Common`, as they now need to revise their libraries to accommodate non-Windows users. This shift requires updating each NuGet package and class library to incorporate new graphics libraries as they are released, potentially slowing the modernization of .NET.

NuGet's pivotal role in advancing .NET can't be overstated—developers rely heavily on these pre-packaged solutions every day.

The implication of this change is a potential slowdown in NuGet developments, risking obsolescence of critical libraries that numerous .NET developers rely on. Prompt and strategic action is essential.

### Our Approach: Bridging Graphic Libraries

IronDrawing provides an intermediary solution that facilitates conversion between old and new graphic libraries, easing the development process. It supports universal graphics class inputs like `Bitmap`, `Color`, `Rectangle`, `Font`, and `Size`, and allows internal operations to remain flexible while adhering to new standards.

**IronDrawing guarantees backward compatibility with .NET Framework 4.62 and fully supports all .NET versions up to .NET 8.**

It converts between the graphic class implementations in `System.Drawing`, `Microsoft.Maui`, `SkiaSharp`, and `SixLabors`, so those classes do not have to be replaced throughout a library.

For instance, `System.Drawing.Bitmap` still works inside IronDrawing through the `AnyBitmap` class, which converts between graphic formats.

### Why We Offer This for Free

At Iron Software, we are dedicated .NET developers enthusiastic about the platform's growth and evolution. By developing IronDrawing, we aim to simplify the transition away from `System.Drawing.Common` and foster the continued prosperity of the .NET and NuGet ecosystems.

## Key Features of `IronSoftware.Drawing`

- **`AnyBitmap`**: A Bitmap class with implicit conversions to and from many formats:
  - `System.Drawing.Bitmap`, `System.Drawing.Image`
  - `SkiaSharp.SKBitmap`, `SkiaSharp.SKImage`
  - `SixLabors.ImageSharp`
  - `Microsoft.Maui.Graphics.Platform.PlatformImage`

- **Color**: A broadly compatible Color class supporting conversions among:
  - `System.Drawing.Color`
  - `SkiaSharp.SKColor`
  - `SixLabors.ImageSharp.Color`
  - `SixLabors.ImageSharp.PixelFormats`

- **`Rectangle`**: A universally compatible Rectangle class that supports conversions between:
  - `System.Drawing.Rectangle`
  - `SkiaSharp.SKRect`, `SkiaSharp.SKRectI`
  - `SixLabors.ImageSharp.Rectangle`

- **Font**: A universally compatible Font class facilitating conversions among:

  - `System.Drawing.Font`
  - `SkiaSharp.SKFont`
  - `SixLabors.Fonts.Font`

- **Installation Made Easy**

Installing the **IronDrawing** (`IronSoftware.Drawing`) package is straightforward:

```shell
:InstallCmd Install-Package IronSoftware.System.Drawing
```

Alternatively, the package is available for download from the [official NuGet website](https://www.nuget.org/packages/IronSoftware.System.Drawing).

Begin using IronDrawing by adding `using IronSoftware.Drawing;` at the start of your C# applications.

## Practical Code Examples

### Example: Utilizing `AnyBitmap`

```csharp
using IronSoftware.Drawing;
using System.IO;
using System.Drawing;

// Initialize a new AnyBitmap instance from a file
var bitmap = AnyBitmap.FromFile("YOUR_FILE_PATH");

// Save the AnyBitmap as a JPEG file
bitmap.SaveAs("output.jpg");

// Convert the AnyBitmap to a byte array, which can be used for network transmission or database storage
var imageBytes = bitmap.ExportBytes();
```


### Example: Working with `Color`

```cs
using IronSoftware.Drawing;
using System;

// The IronSoftware.Drawing library provides enhanced color manipulation features.
// This example demonstrates creating color objects and converting between
// System.Drawing.Color and IronSoftware.Drawing.Color.

// Create a new Color object from a hex string.
Color fromHex = new Color("#191919");

// Create a new Color object from RGB values.
Color fromRgb = new Color(255, 255, 0);

// Create a new Color object using an enumeration.
Color fromEnum = Color.Crimson;

// Casting between System.Drawing.Color and IronSoftware.Drawing.Color.
System.Drawing.Color drawingColor = System.Drawing.Color.Red;

// Convert System.Drawing.Color to IronSoftware.Drawing.Color.
IronSoftware.Drawing.Color ironColor = drawingColor; // implicit conversion

// Access the alpha, red, green, and blue components of the IronSoftware.Drawing.Color.
byte alpha = ironColor.A;
byte red = ironColor.R;
byte green = ironColor.G;
byte blue = ironColor.B;

// Calculate the luminance of the color.
// Luminance is a value from 0 (black) to 100 (white) where 50 is the perceptual "middle grey".
double luminance = ironColor.GetLuminance();

// Log the calculated attributes to the console.
Console.WriteLine($"Color Details - ARGB: ({alpha}, {red}, {green}, {blue}), Luminance: {luminance}");
```

> The guide builds these with `Color.FromHex`, `Color.FromRgb` and
> `Color.FromSystemColor`. None of the three ships in
> `IronSoftware.Drawing`: there is a string constructor, an `(r, g, b)`
> constructor, and an implicit conversion from `System.Drawing.Color`.

### Example: Working with `Rectangle`

```cs
using System.Drawing;
using IronSoftware.Drawing;

// Declare an IronSoftware.Drawing.Rectangle object
IronSoftware.Drawing.Rectangle ironRectangle = new IronSoftware.Drawing.Rectangle(5, 5, 50, 50);

// Declare a System.Drawing.Rectangle object
System.Drawing.Rectangle systemRectangle = new System.Drawing.Rectangle(10, 10, 150, 150);

// Implicitly convert System.Drawing.Rectangle to IronSoftware.Drawing.Rectangle
// Note: Uncomment and use appropriate conversion methods if available in the IronSoftware.Drawing library
// ironRectangle = (IronSoftware.Drawing.Rectangle)systemRectangle;

// Output the properties of IronSoftware.Drawing.Rectangle if conversion is successful
// These Console.WriteLine statements assume this code runs in a console environment
Console.WriteLine(ironRectangle.X);
Console.WriteLine(ironRectangle.Y);
Console.WriteLine(ironRectangle.Width);
Console.WriteLine(ironRectangle.Height);
```

### Example: Working with `Font`

```cs
using IronSoftware.Drawing;

// Create a new Font object with a specified font family, style, and size
IronSoftware.Drawing.Font font = new IronSoftware.Drawing.Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);

// Create a new instance of System.Drawing.Font
System.Drawing.Font drawingFont = new System.Drawing.Font("Courier New", 30);

try
{
    // The two FontStyle enums share their member values, so the style
    // carries across with an explicit cast.
    IronSoftware.Drawing.Font ironFont = new IronSoftware.Drawing.Font(
        drawingFont.FontFamily.Name,
        (IronSoftware.Drawing.FontStyle)(int)drawingFont.Style,
        drawingFont.Size);

    // Accessing properties of the IronSoftware.Drawing.Font object
    string familyName = ironFont.FamilyName; // Get the font family name
    FontStyle style = ironFont.Style;       // Get the combined font style (italic, bold, etc.)
    float size = ironFont.Size;             // Get the font size
    bool isItalic = ironFont.Italic;        // Determine if the font style includes Italic
    bool isBold = ironFont.Bold;            // Determine if the font style includes Bold

    // Output the font properties to verify correctness
    Console.WriteLine($"Family: {familyName}, Style: {style}, Size: {size}, Italic: {isItalic}, Bold: {isBold}");
}
catch (InvalidCastException)
{
    Console.WriteLine("The conversion between System.Drawing.Font and IronSoftware.Drawing.Font is not directly supported.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
```

> The guide passes `drawingFont.Style` straight into the
> `IronSoftware.Drawing.Font` constructor. The two `FontStyle` enums are
> distinct types, so that does not compile; their members share values, so an
> explicit cast carries the style across.

## Support

IronDrawing is released under the Apache 2.0 licence and is free for commercial
use. The source lives on
[GitHub](https://github.com/iron-software/IronSoftware.System.Drawing), where
issues and pull requests are welcome.
