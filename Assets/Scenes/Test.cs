using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Update()
    {
        Debug.LogFormat("LDown {0}, LRight: {1}", Input.GetAxis(PSButton.LDown.ToValue()), Input.GetAxis(PSButton.LRight.ToValue()));
        Debug.LogFormat("RDown {0}, RRight: {1}", Input.GetAxis(PSButton.RDown.ToValue()), Input.GetAxis(PSButton.RRight.ToValue()));
        Debug.LogFormat("R2 {0}, L2 {1}", Input.GetAxis(PSButton.R2.ToValue()), Input.GetAxis(PSButton.L2.ToValue()));

        if (Input.GetAxis(PSButton.Up.ToValue()) == 1)
        {
            print("down");
        }
        else if (Input.GetAxis(PSButton.Up.ToValue()) == -1)
        {
            print("up");
        }

        if (Input.GetAxis(PSButton.Right.ToValue()) == 1)
        {
            print("right");
        }
        else if (Input.GetAxis(PSButton.Right.ToValue()) == -1)
        {
            print("left");
        }
        if (Input.GetButton(PSButton.L1.ToValue())) { print("l1"); }
        if (Input.GetButton(PSButton.L3.ToValue())) { print("l3"); }
        if (Input.GetButton(PSButton.R1.ToValue())) { print("r1"); }
        if (Input.GetButton(PSButton.R3.ToValue())) { print("r3"); }
        if (Input.GetButton(PSButton.Circle.ToValue())) { print("circle"); }
        if (Input.GetButton(PSButton.Rectangle.ToValue())) { print("rectangle"); }
        if (Input.GetButton(PSButton.Triangle.ToValue())) { print("triangle"); }
        if (Input.GetButton(PSButton.Cross.ToValue())) { print("cross"); }
    }
}
