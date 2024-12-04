# Utilizing IronBarCode with .NET on Azure Platforms

***Based on <https://ironsoftware.com/docs/questions/azure-support/>***


Indeed, IronBarCode seamlessly integrates with Azure, enabling the creation and recognition of QR & Barcodes in both C# and VB .NET applications. It also supports reading from scanned images and has been extensively validated across various Azure deployments like MVC websites and Azure Functions.

---

## Get Started with IronBarCode

Begin by installing IronBarCode using NuGet:

[IronBarCode on NuGet](https://www.nuget.org/packages/BarCode)

Execute the following command to install:

```shell
Install-Package IronSoftware.System.Drawing
```

---

## Performance Considerations and Azure Hosting Tips

For handling library requirements efficiently, Azure **B1** hosting tiers are recommended. For systems requiring high throughput, consider opting for higher tiers.

### Choice of Framework

IronBarCode is compatible with both .NET Core and .NET Framework on Azure. Applications built on .NET Standard tend to run slightly faster and more stable, albeit consuming more memory.

#### Note on Azure's Free and Shared Hosting

The free and shared tiers on Azure, including the consumption plan, do not provide optimal performance for QR processing. We suggest the Azure B1 hosting or Premium plans, which we use for our needs.

## Implementing Docker for Enhanced Control

Deploying IronBarCode within Docker containers on Azure can significantly enhance performance management capabilities. 

Explore our detailed guide for setting IronBarCode up on Docker for both Linux and Windows:

[IronBarCode Azure Docker Integration Guide](https://ironsoftware.com/csharp/barcode/how-to/docker-linux/)

## Support for Azure Functions

IronBarCode is currently supported on Azure Functions V3. Testing for V4 is in progress and upcoming in our development roadmap.

### Sample Azure Function for Barcode Generation

The following example, tested on Azure Functions v3.3.1.0 and newer, demonstrates generating a QR code:

```csharp
[FunctionName("barcode")]
public static HttpResponseMessage Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");
    IronBarCode.License.LicenseKey = "Key";
    var MyBarCode = BarcodeWriter.CreateBarcode("IronBarcode Test", BarcodeEncoding.QRCode);
    var result = new HttpResponseMessage(HttpStatusCode.OK);
    result.Content = new ByteArrayContent(MyBarCode.ToJpegBinaryData());
    result.Content.Headers.ContentDisposition =
            new ContentDispositionHeaderValue("attachment") { FileName = $"{DateTime.Now.ToString("yyyyMMddmm")}.jpg" };
    result.Content.Headers.ContentType =
            new MediaTypeHeaderValue("image/jpeg");
    return result;
}
```

This tutorial offers a glimpse into how you can leverage IronBarCode efficiently in the Azure cloud environment, enhancing your .NET applications with robust barcode and QR code functionalities.