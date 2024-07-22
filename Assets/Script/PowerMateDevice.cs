using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
[InputControlLayout(stateType = typeof(PowerMateReport))]
public class PowerMateDevice : InputDevice, IInputStateCallbackReceiver
{
    public IntegerControl xy { get; protected set; }
    // public IntegerControl knobDisplacement { get; protected set; }

    static PowerMateDevice()
    {
        Initialize();
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        InputSystem.RegisterLayout<PowerMateDevice>(
            matches: new InputDeviceMatcher()
                .WithInterface("HID")
                .WithProduct("QBR7 HID"));
    }

    protected override void FinishSetup()
    {
        xy = TryGetChildControl<IntegerControl>("xy");
        // knobDisplacement = TryGetChildControl<IntegerControl>("KnobDisplacement");
    }

    public void OnNextUpdate()
    {
        InputState.Change(xy, 0);
    }

    public void OnStateEvent(InputEventPtr eventPtr)
    {
        InputState.Change(this, eventPtr);
    }

    public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
    {
        return false;
    }
}

// {
//     "interface": "HID",
//     "type": "",
//     "product": "QBR7 HID",
//     "serial": "",
//     "version": "256",
//     "manufacturer": "Quanta Computer",
//     "capabilities": "{\"vendorId\":51966,\"productId\":16389,\"usage\":1,\"usagePage\":65280,\"inputReportSize\":65,\"outputReportSize\":65,\"featureReportSize\":0}"
// }