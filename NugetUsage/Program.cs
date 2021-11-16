using System;
using System.Drawing.Imaging;
using LoremNETCore;
using Spire.Barcode;

namespace NugetUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoremNETCore.Generate.Paragraph(20, 2));

            for(int i = 0;i < 20;i++)
                Console.WriteLine(LoremNETCore.Generate.Email());

            BarcodeSettings settings = new BarcodeSettings();
            settings.Data           = "TICKET 001";
            settings.Data2D         = "http://google.com";
            settings.QRCodeDataMode = QRCodeDataMode.AlphaNumber;
            settings.X              = 1.0f;
            settings.QRCodeECL      = QRCodeECL.H;


            BarCodeGenerator generator = new BarCodeGenerator(settings);
            generator.GenerateImage().Save(@"D:\Capgemini Training\Temp\MyQrCode.jpg", ImageFormat.Jpeg);



        }
    }
}
