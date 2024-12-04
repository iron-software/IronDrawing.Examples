# Replace `System.Drawing.Common` with IronDrawing in .NET Applications

***Based on <https://ironsoftware.com/docs/docs/>***


## Open-Source IronDrawing Supports Most .NET Drawing Library Formats for Free

**IronDrawing**, developed by Iron Software, serves as an innovative open-source library, designed to assist C# developers in substituting `System.Drawing.Common` within .NET applications, across various operating systems including Windows, macOS, and Linux.

Creating class libraries and NuGet packages that integrate with .NET 5 through 8 should be straightforward. **IronDrawing** provides a crucial integration service, aligning itself with the evolving .NET graphics standards, allowing developers to focus on their preferred version.

<div class="content-img-align-center">
  <div class="center-image-wrapper">
  <img src="https://ironsoftware.com/static-assets/drawing/irondrawing-get-started.webp" alt="IronDrawing, a robust open-source tool supporting various .NET drawing library formats" class="img-responsive add-shadow" width="645" height="618">
</div>
</div>

### Overview

Microsoft .NET is used worldwide by a vast number of developers, owing to its extensive compatibility across platforms. Recently, Microsoft made a significant shift by [declaring](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only) that `System.Drawing.Common` will be confined to the Windows platform going forward.

This change poses significant challenges for developers who manage cross-platform libraries, relying on `System.Drawing.Common`. Microsoft's [recommended solution](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only#recommended-action) dictates that libraries be updated to accommodate users outside of Windows. This requirement could lead to substantial technical debt, potentially disrupting the rapid adoption of newer .NET versions.

The reality is, the .NET community relies heavily on NuGet for streamlined development processes. The required updates due to this change may decelerate development within the NuGet ecosystem, risking outdated or abandoned libraries crucial for many users. Immediate action is necessary.

### Solution by IronDrawing

IronDrawing introduces a versatile interface adapting between both legacy and modern graphics libraries. It simplifies developers' requirements by maintaining consistent public interfaces such as `Bitmap`, `Color`, `Rectangle`, `Font`, and `Size` yet allows internal operations to adapt to any new standards.

**IronDrawing** is fully compatible with older .NET Framework versions starting from 4.62 and extends through the entire current range up to .NET 8.

This strategic development eradicates the challenges posed by Microsoft's breaking change, offering a streamlined, open-source strategy for important class types such as `Bitmap`, `Color`, `Rectangle`, `Font`, and `Size`. These types can be interconverted seamlessly using **`IronSoftware.Drawing`**, bridging differences whether they originate from `System.Drawing`, `Microsoft.Maui`, `SkiaSharp`, or `SixLabors`.

For instance, while using the `System.Drawing.Bitmap`, IronDrawing’s `AnyBitmap` class allows intuitive transitions among different types such as `System.Drawing.Image` or `SkiaSharp.SKBitmap`.

### Why IronDrawing is Freely Available

At Iron Software, our commitment as experienced .NET developers is to aid the progression and accessibility of .NET technologies. By developing IronDrawing and providing it for free, we seek to simplify transitions away from `System.Drawing`, hoping to support a sustainable, thriving future for .NET and its developers.

## Features of `IronSoftware.Drawing`

- **`AnyBitmap`**: Universal Bitmap compatibility. Easy conversion exists between `AnyBitmap` and the following types:
  - `System.Drawing.Bitmap`
  - `SkiaSharp.SKBitmap`
  - `SixLabors.ImageSharp`, etc.
- **Color**: Universal compatibility. Implicit conversions supported with:
  - `System.Drawing.Color`
  - `SkiaSharp.SKColor`
  - `SixLabors.ImageSharp.Color`, etc.
- **`Rectangle`**: Universally adaptable, with transfers possible among:
  - `System.Drawing.Rectangle`
  - `SkiaSharp.SKRect`
  - `SixLabors.ImageSharp.Rectangle`, etc.
- **Font**: Universal Font class, allowing smooth transitions between:
  - `System.Drawing.Font`
  - `SkiaSharp.SKFont`
  - `SixLabors.Fonts.Font`, etc.

### IronDrawing Compatibility

Support spans a broad spectrum including:
- All recent and upcoming versions of .NET from 5 to 8
- Environments such as Windows, macOS, Linux, Docker, Azure, and AWS

## Installation Procedure

To integrate IronDrawing, simply install the `IronSoftware.Drawing` from NuGet:

```shell
:InstallCmd Install-Package IronSoftware.System.Drawing
```

For direct access, visit the [official NuGet page](https://www.nuget.org/packages/IronSoftware.System.Drawing).

Start using it by adding `using IronSoftware.Drawing;` to your C# project files.

## Usage Examples

### Handling Bitmaps with `AnyBitmap`

```cs
using IronSoftware.Drawing;
using IronSoftware.System.Drawing;

namespace irondrawing.Quickstart
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate an AnyBitmap from a file
            var bitmap = AnyBitmap.FromFile("FILE_PATH");
            bitmap.SaveAs("result.jpg");
            
            var bytes = bitmap.ExportBytes();
            
            var resultExport = new System.IO.MemoryStream();
            bitmap.ExportStream(resultExport, AnyBitmap.ImageFormat.Jpeg, 100);
            
            // Convert System.Drawing.Bitmap to AnyBitmap
            System.Drawing.Bitmap image = new System.Drawing.Bitmap("FILE_PATH");
            IronSoftware.Drawing.AnyBitmap anyBitmap = image;
            anyBitmap.SaveAs("result-from-casting.png");
        }
    }
}
```

### Utilizing the `Color` Class

```cs
using IronSoftware.Drawing;
using IronSoftware.System.Drawing;

namespace irondrawing.Quickstart
{
    public class Section2
    {
        public void Run()
        {
            // Construct a new Color instance
            Color fromHex = new Color("#191919");
            Color fromRgb = new Color(255, 255, 0);
            Color fromEnum = Color.Crimson;
            
            // Convert System.Drawing.Color to IronSoftware.Drawing.Color
            System.Drawing.Color drawingColor = System.Drawing.Color.Red;
            IronSoftware.Drawing.Color ironColor = drawingColor;
            
            // Access color channels and luminance
            ironColor.A;
            ironColor.R;
            ironColor.G;
            ironColor.B;
            
            IronDrawingColor.GetLuminance();
        }
    }
}
```

### `Rectangle` Class Example

```cs
using IronSoftware.Drawing;
using IronSoftware.System.Drawing;

namespace irondrawing.Quickstart
{
    public class Section3
    {
        public