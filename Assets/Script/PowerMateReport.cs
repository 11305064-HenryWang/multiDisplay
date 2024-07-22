using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

[StructLayout(LayoutKind.Explicit)]
public struct PowerMateReport : IInputStateTypeInfo
{
    public FourCC format => new ('H', 'I', 'D');

    [FieldOffset(0)]
    [InputControl(name = "xy", layout = "Integer", format = "BYTE")]
    public byte xy;

    // [FieldOffset(2)]
    // [InputControl(name = "KnobDisplacement", layout = "Integer", format = "BYTE")]
    // public byte KnobDisplacement;
}

// {
//     "interface": "HID",
//     "type": "",
//     "product": "Rokid Max",
//     "serial": "1501082318002309",
//     "version": "512",
//     "manufacturer": "Rokid Corporation Ltd.",
//     "capabilities": "{\"vendorId\":1234,\"productId\":5679,\"usage\":1,\"usagePage\":65280,\"inputReportSize\":64,\"outputReportSize\":64,\"featureReportSize\":0}"
// }


// {
//     "interface": "HID",
//     "type": "",
//     "product": "QBR7 HID",
//     "serial": "",
//     "version": "256",
//     "manufacturer": "Quanta Computer",
//     "capabilities": "{\"vendorId\":51966,\"productId\":16389,\"usage\":1,\"usagePage\":65280,\"inputReportSize\":65,\"outputReportSize\":65,\"featureReportSize\":0}"
// }