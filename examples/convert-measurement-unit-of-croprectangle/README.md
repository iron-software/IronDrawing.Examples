***Based on <https://ironsoftware.com/examples/convert-measurement-unit-of-croprectangle/>***

IronDrawing offers functionality allowing users to switch the unit of measurement in `Rectangle` or `RectangleF` from pixels (px) to millimeters (mm) and vice versa. By default, `Rectangle` and `RectangleF` use pixels (px) as their measurement unit.

To convert the dimensions of a newly created `Rectangle`, invoke the conversion method on it like so: `.ConvertTo(MeasurementUnits.Millimeters, 20)`. This method adjusts the rectangle's size to millimeters, depending on the DPI value specified by the user. The `RectangleF` class can be modified in the same manner.