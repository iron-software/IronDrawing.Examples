***Based on <https://ironsoftware.com/examples/convert-measurement-unit-of-croprectangle/>***

IronDrawing offers a feature for users to modify the measurement unit of `Rectangle` or `RectangleF` objects, allowing a switch from pixels (px) to millimeters (mm) and back. By default, these objects use pixels (px) as their unit of measurement.

Once a `Rectangle` object has been created with specified dimensions, you can use the conversion method on it. For instance, invoking `.ConvertTo(MeasurementUnits.Millimeters, 20)` on a `Rectangle` object converts its dimensions from pixels to millimeters, depending on the DPI (Dots Per Inch) specified by the user. This technique is equally applicable to the `RectangleF` class.