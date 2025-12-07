***Based on <https://ironsoftware.com/examples/convert-measurement-unit-of-croprectangle/>***

IronDrawing offers a functionality for those looking to alternate the measurement units in `Rectangle` or `RectangleF` between pixels (px) and millimeters (mm), or the other way around. By default, the units in `Rectangle` and `RectangleF` are in pixels (px).

Upon creating a `Rectangle` with specified dimensions, you can utilize a method to convert these measurements. For instance, by calling `.ConvertTo(MeasurementUnits.Millimeters, 20)` on a `Rectangle`, the dimensions are transformed into millimeters, considering the DPI predefined by the user. This method can equally be applied to the `RectangleF` class.