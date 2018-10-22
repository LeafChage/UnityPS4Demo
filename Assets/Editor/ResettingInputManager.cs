using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ResettingInputManager
{
    [MenuItem("Setting/Reset InputManager")]
    public static void Resetting()
    {
        Debug.Log("start to change input manger");
        InputManagerGenerator gen = new InputManagerGenerator();
        gen.Clear();
        gen.AddAxis(InputAxis.Init("LRight", "", "", "a", "d", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 1, 0));
        gen.AddAxis(InputAxis.Init("LDown", "", "", "s", "w", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 2, 0));
        gen.AddAxis(InputAxis.Init("RRight", "", "", "", "", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 3, 1));
        gen.AddAxis(InputAxis.Init("RDown", "", "", "", "", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 4, 1));
        gen.AddAxis(InputAxis.Init("L2", "", "", "", "", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 5, 1));
        gen.AddAxis(InputAxis.Init("R2", "", "", "", "", 0, 0.1f, 2, true, false, AxisType.JoystickAxis, 6, 1));
        gen.AddAxis(InputAxis.Init("L1", "", "joystick button 4", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("R1", "", "joystick button 5", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("L3", "", "joystick button 10", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("R3", "", "joystick button 11", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("Rectangle", "", "joystick button 0", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("Cross", "", "joystick button 1", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("Circle", "", "joystick button 2", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("Triangle", "", "joystick button 3", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
        gen.AddAxis(InputAxis.Init("Right", "", "", "", "", 0, 0.1f, 1000, false, false, AxisType.JoystickAxis, 7, 1));
        gen.AddAxis(InputAxis.Init("Up", "", "", "", "", 0, 0.1f, 1000, false, false, AxisType.JoystickAxis, 8, 1));
        gen.AddAxis(InputAxis.Init("None", "", "", "", "", 1000, 0.1f, 1000, false, false, AxisType.KeyOrMouseButton, 1, 1));
    }
}
