# Replace `System.Drawing.Common` with IronDrawing in .NET Projects

***Based on <https://ironsoftware.com/docs/docs/>***


## Discover IronDrawing: Your Open-Source Solution Across All .NET Platforms

**IronDrawing**, a comprehensive and open-source library crafted by Iron Software, empowers C# developers to seamlessly substitute `System.Drawing.Common` across diverse platforms like Windows, macOS, and Linux in their .NET projects.

Creating class libraries and NuGet packages that handle graphics, images, and fonts across .NET 5, 6, 7, & 8 should be straightforward and efficient.

IronDrawing integrates flawlessly with the evolving .NET graphics standards starting from .NET 5 to .NET 8, allowing developers to focus on their preferred environment without hassle.

<div class="content-img-align-center">
  <div class="center-image-wrapper">
    <img src="https://ironsoftware.com/static-assets/drawing/irondrawing-get-started.webp" alt="IronDrawing: Open-source and versatile for all .NET drawing formats" class="img-responsive add-shadow" width="645" height="618">
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

It's designed to convert seamlessly between different graphic class implementations like `System.Drawing`, `Microsoft.Maui`, `SkiaSharp`, and `SixLabors`, streamlining the development process by removing the need to replace these classes throughout libraries.

For instance, you may continue using `System.Drawing.Bitmap` within IronDrawing via its `AnyBitmap` class, which supports effortless conversions between various graphic formats.

### Why We Offer This for Free

At Iron Software, we are dedicated .NET developers enthusiastic about the platform's growth and evolution. By developing IronDrawing, we aim to simplify the transition away from `System.Drawing.Common` and foster the continued prosperity of the .NET and NuGet ecosystems.

## Key Features of `IronSoftware.Drawing`

- **`AnyBitmap`**: A versatile Bitmap class with implicit conversions to and from numerous formats:
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