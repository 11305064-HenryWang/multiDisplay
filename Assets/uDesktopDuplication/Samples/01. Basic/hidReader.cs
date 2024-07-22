// using System;
// using System.Linq;
// using System.Threading;
// using HidLibrary;

// namespace HidDeviceReader
// {
//     class Program
//     {
//         private const int VendorId = 0xCAFE;
//         private const int ProductId = 0x4005;
//         private static bool _running = true;

//         static void Main(string[] args)
//         {
//             var device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();

//             if (device != null && device.IsConnected)
//             {
//                 Console.WriteLine("Device found. Starting read thread.");
//                 device.OpenDevice();

//                 var readThread = new Thread(() => ReadDevice(device));
//                 readThread.Start();

//                 Console.WriteLine("Press any key to stop...");
//                 Console.ReadKey();

//                 _running = false;
//                 readThread.Join();

//                 device.CloseDevice();
//                 Console.WriteLine("Device closed.");
//             }
//             else
//             {
//                 Console.WriteLine("Device not found.");
//             }
//         }

//         private static void ReadDevice(HidDevice device)
//         {
//             while (_running)
//             {
//                 var data = device.Read(); // This is a blocking call.
//                 if (data.Status == HidDeviceData.ReadStatus.Success)
//                 {
//                     // Process your data here. Example:
//                     Console.WriteLine(BitConverter.ToString(data.Data));
//                 }
//             }
//         }
//     }
// }

// // {
// //     "interface": "HID",
// //     "type": "",
// //     "product": "ITE Device(8910)",
// //     "serial": "",
// //     "version": "3",
// //     "manufacturer": "ITE Tech. Inc.",
// //     "capabilities": "{\"vendorId\":2821,\"productId\":6582,\"usage\":65295,\"usagePage\":65417,\"inputReportSize\":2,\"outputReportSize\":0,\"featureReportSize\":0,\"elements\":[{\"usage\":1,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":9,\"flags\":6},{\"usage\":2,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":10,\"flags\":6},{\"usage\":3,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":11,\"flags\":6},{\"usage\":4,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":12,\"flags\":6},{\"usage\":5,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":13,\"flags\":6},{\"usage\":6,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":14,\"flags\":6},{\"usage\":7,\"usagePage\":65417,\"unit\":0,\"unitExponent\":0,\"logicalMin\":0,\"logicalMax\":0,\"physicalMin\":0,\"physicalMax\":0,\"collectionIndex\":0,\"reportType\":1,\"reportId\":5,\"reportCount\":1,\"reportSizeInBits\":1,\"reportOffsetInBits\":15,\"flags\":6}],\"collections\":[]}"
// // }