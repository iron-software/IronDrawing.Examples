# C# Bitmap Library to Transition Away from `System.Drawing.Common` in .NET

***Based on <https://ironsoftware.com/docs/docs/>***


## IronDrawing: Open-Source and Broadly Compatible with .NET Drawing Libraries

**IronDrawing**, crafted by Iron Software, is a sophisticated open-source library designed to facilitate the transition away from `System.Drawing.Common` for C# developers. This library ensures compatibility across various platforms including Windows, macOS, and Linux, streamlining the development process with the evolving standards of .NET versions: 5, 6, 7, and 8.

<div class="content-img-align-center">
  <div class="center-image-wrapper">
  <img src="https://ironsoftware.com/static-assets/drawing/irondrawing-get-started.webp" alt="IronDrawing Overview Image" class="img-responsive add-shadow" width="645" height="618">
</div>
</div>

### Background

Microsoft's .NET is a versatile and widely used software framework that supports a multitude of platforms. Recent announcements from Microsoft have highlighted a significant change: `System.Drawing.Common` will now be supported exclusively on Windows systems.

This change presents challenges for developers who maintain cross-platform libraries, as Microsoft suggests that to accommodate non-Windows users, library developers must rebuild their libraries for different platforms frequently as new graphic libraries are introduced. This may lead to considerable technical debt and delay the adoption of contemporary .NET features.

NuGet packages play a vital role here, representing a significant part of everyday .NET usage, accelerating developments that would otherwise take extensive amounts of time and resources.

### Our Solution

IronDrawing offers a unified intermediary format that facilitates the conversion between various old and new graphic libraries. It allows developers to only deal with one set type for standard types like `Bitmap`, `Color`, `Rectangle`, `Font`, and `Size`, while internally managing compatibility with multiple standards.

Furthermore, IronDrawing is backward compatible up to .NET Framework 4.62 and extends support through to .NET 8, ensuring that switching to modern .NET ecosystems is seamless without needing extensive reimplementation of existing library elements.

For [example](#anchor-anybitmap-example), IronDrawing provides the `AnyBitmap` class, which allows easy conversions between different forms such as `System.Drawing.Bitmap` and other formats like `SkiaSharp.SKBitmap` and `Microsoft.Maui.Graphics.Platform.PlatformImage`.

### Our Motivation for Offering This Free

IronDrawing is a result of Iron Software's commitment to the growth and advancement of the .NET platform. Our team, comprising senior .NET developers, is enthusiastic about facilitating a smooth transition for developers away from `System.Drawing` and towards newer technologies.

By making library and NuGet package development simpler, we aim to support the continued prosperity of the NuGet ecosystem and the broader .NET developer community.

## Features of `IronSoftware.Drawing`

- **`AnyBitmap`**: A versatile bitmap class that allows implicit conversions to and from `IronSoftware.Drawing.AnyBitmap` and multiple other bitmap types.
- **`Color`**: This class provides universal compatibility and seamless transition between different color formats like `System.Drawing.Color` and `SkiaSharp.SKColor`.
- **`Rectangle`**: Ensures universal compatibility and allows conversions between different rectangle definitions.
- **`Font`**: This facilitates easy transitions between various font standards, maintaining compatibility and simplifying usage.

### Compatibility

**`IronSoftware.Drawing`** supports all contemporary and legacy .NET implementations including .NET 8 through .NET 5, .NET Core and Standard, and .NET Framework 4.62+, across different platforms like Windows, macOS, Linux, as well as cloud environments like Docker, Azure, and AWS.

## How to Install

The installation process of the IronDrawing library (`IronSoftware.Drawing`) is straightforward:

```shell
:InstallCmd Install-Package IronSoftware.System.Drawing
```

Or download it directly from the [NuGet official site](https://www.nuget.org/packages/IronSoftware.System.Drawing).

Start by adding `using IronSoftware.Drawing;` at the beginning of your C# files to access its functionalities.

## Example Usage

### An Example of Using AnyBitmap

```cs
using IronSoftware.Drawing;

// Initialize an AnyBitmap from a file
var bitmap = AnyBitmap.FromFile("FILE_PATH");
bitmap.SaveAs("result.jpg");

var bytes = bitmap.ExportBytes();

var resultStream = new System.IO.MemoryStream();
bitmap.ExportStream(resultStream, AnyBitmap.ImageFormat.Jpeg, 100);

// Demonstrating casting between System.Drawing.Bitmap and AnyBitmap
System.Drawing.Bitmap stdBitmap = new System.Drawing.Bitmap("FILE_PATH");
IronSoftware.Drawing.AnyBitmap anyBitmap = stdBitmap;
anyBitmap.SaveAs("result-after-casting.png");
```

### An Example of Using Color

```cs
using IronSoftware.Drawing;

// Initialize various Color objects
Color fromHex = new Color("#191919");
Color fromRgb = new Color(255, 255, 0);
Color fromEnum = Color.Crimson;

// Demonstrate casting between System.Drawing.Color and IronSoftware.Drawing.Color
System.Drawing.Color systemColor = System.Drawing.Color.Red;
IronSoftware.Drawing.Color ironColor = systemColor;

// Display RGBA values
ironColor.A;
ironColor.R;
ironColor.G;
ironColor.B;

// Calculate luminance
IronDrawingColor.GetLuminance();
```

### Using Rectangle

```cs
using IronSoftware.Drawing;

// Create and utilize IronSoftware.Drawing.Rectangle
Rectangle ironRect = new Rectangle(5, 5, 50, 50);

// Convert from System.Drawing.Rectangle
System.Drawing.Rectangle systemRect = new System.Drawing.Rectangle(10, 10, 150, 150);
IronSoftware.Drawing.Rectangle convertedRect = systemRect;

// Access properties
convertedRect.X;
convertedRect.Y;
convertedRect.Width;
convertedRect.Height;
```

### Using Font

```cs
using IronSoftware.Drawing;

// Initialize IronSoftware.Drawing.Font
Font ironFont = new Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);

// Convert from System.Drawing.Font
System.Drawing.Font systemFont = new System.Drawing.Font("Courier New", 30);
IronSoftware.Drawing.Font convertedFont = systemFont;

// Access font properties
convertedFont.FamilyName;
convertedFont.Style;
convertedFont.Size;
convertedFont.Italic;
convertedFont.Bold;
```

## Support and Contribution

### Licensing

Find the license details here: [LICENSE.txt](https://github.com/iron-software/IronSoftware.System.Drawing/blob/master/LICENSE.txt)

### How to Contribute

Interested in contributing? Please review the [project license](https://github.com/iron-software/IronSoftware.System.Drawing/blob/master/LICENSE.txt) and consider making a pull request to our [GitHub repository](https://github.com/iron-software/IronSoftware.System.Drawing).

### More Information and Support

To learn more about Iron Software and our products, visit our official site at <https://ironsoftware.com/>

For technical support and inquiries, reach out to us at: <mailto:support@ironsoftware.com>