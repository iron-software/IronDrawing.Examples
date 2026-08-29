# IronDrawing.Examples

Runnable C# examples for [IronDrawing](https://ironsoftware.com/open-source/csharp/drawing/?utm_source=github), a free and open-source .NET graphics library that replaces `System.Drawing.Common` with types that convert implicitly to and from SkiaSharp, ImageSharp, MAUI Graphics, and `System.Drawing` itself.

## Install

```bash
dotnet add package IronSoftware.System.Drawing
```

## Quickstart

```csharp
using IronSoftware.Drawing;

// Load an image from disk into an AnyBitmap
var bitmap = AnyBitmap.FromFile("input.png");

// Save it back out in a different format
bitmap.SaveAs("result.jpg");

// Export to a byte array or a stream for network or database use
byte[] bytes = bitmap.ExportBytes();

using var stream = new MemoryStream();
bitmap.ExportStream(stream, AnyBitmap.ImageFormat.Jpeg, 100);
```

`AnyBitmap` converts implicitly to and from `System.Drawing.Bitmap`, `SkiaSharp.SKBitmap`, `SixLabors.ImageSharp.Image`, and `Microsoft.Maui.Graphics.Platform.PlatformImage`, so it can sit between two libraries that would otherwise not agree on an image type. `Color`, `Rectangle`, `Size`, `Point`, and `Font` behave the same way.

IronDrawing is free and open source — no license key is required.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `quickstart/` — an end-to-end project scaffold

## Common tasks covered

- Loading, cloning, and saving `AnyBitmap` images across formats
- Casting between `AnyBitmap` and `System.Drawing`, SkiaSharp, ImageSharp, and MAUI image types
- Exporting images to `byte[]` and `MemoryStream`, and to a string with `ToString()`
- Reading and setting individual pixels
- Multi-frame images: creating multi-page TIFF and GIF, counting frames, extracting a single frame
- Color creation, 32-bit ARGB conversion, and color-depth inspection
- `CropRectangle` construction, casting, and measurement-unit conversion
- `Point`, `PointF`, `Rectangle`, `RectangleF`, `Size`, and `SizeF` arithmetic, casting, and equality

## Platform support

.NET Standard 2.0 and .NET 6 — which covers .NET 8, 7, 6, 5, .NET Core, and .NET Framework 4.6.1+. Windows, macOS, Linux, Docker, Azure, and AWS. See the [documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/?utm_source=github) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/open-source/csharp/drawing/docs](https://ironsoftware.com/open-source/csharp/drawing/docs/?utm_source=github)
- API reference: [ironsoftware.com/open-source/csharp/drawing/object-reference/api](https://ironsoftware.com/open-source/csharp/drawing/object-reference/api/?utm_source=github)
- Library source and issues: [github.com/iron-software/IronSoftware.System.Drawing](https://github.com/iron-software/IronSoftware.System.Drawing)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/?utm_source=github). IronDrawing is free and open source; the rest of the Iron Suite is commercial.
