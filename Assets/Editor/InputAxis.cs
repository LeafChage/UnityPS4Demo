using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum AxisType
{
	KeyOrMouseButton,
	MouseMovement,
	JoystickAxis
};

public class InputAxis: Editor
{
    public string name = "";
    public string descriptiveName = "";
    public string descriptiveNegativeName = "";
    public string negativeButton = "";
    public string positiveButton = "";
    public string altNegativeButton = "";
    public string altPositiveButton = "";
    public float gravity = 0;
    public float dead = 0;
    public float sensitivity = 0;
    public bool snap = false;
    public bool invert = false;
    public AxisType type = AxisType.KeyOrMouseButton;
    public int axis = 1;
    public int joyNum = 0;

    public static InputAxis Init(string name, string descriptiveName, string descriptiveNegativeName, string negativeButton, string positiveButton,
        string altNegativeButton, string altPositiveButton, float gravity, float dead, float sensitivity,
        bool snap, bool invert, AxisType type, int axis, int joyNum)
    {
        var inputAxis = new InputAxis();
        inputAxis.name = name;
        inputAxis.descriptiveName = descriptiveName;
        inputAxis.descriptiveNegativeName = descriptiveNegativeName;
        inputAxis.negativeButton = negativeButton;
        inputAxis.positiveButton = positiveButton;
        inputAxis.altNegativeButton = altNegativeButton;
        inputAxis.altPositiveButton = altPositiveButton;
        inputAxis.gravity = gravity;
        inputAxis.dead = dead;
        inputAxis.sensitivity = sensitivity;
        inputAxis.snap = snap;
        inputAxis.invert = invert;
        inputAxis.type = type;
        inputAxis.axis = axis;
        inputAxis.joyNum = joyNum;
        return inputAxis;
    }

    /*
    Gravityはキーを離してから0に戻るまでの秒速
    Deadは指定した値以下のキー入力値だった時は0にする設定
    Sensitivityはターゲットの入力値になるまでの秒速
    Snapにチェックを入れると反対方向のキーを押した時に値が0になる
    Invertにチェックを入れるとキーの入力が反対になる
     */
    public static InputAxis Init(string name, string negativeButton, string positiveButton, string altNegativeButton, string altPositiveButton, float gravity, float dead, float sensitivity, bool snap, bool invert, AxisType type, int axis, int joyNum)
    {
		var inputAxis = new InputAxis();
        inputAxis.name = name;
        inputAxis.descriptiveName = "";
        inputAxis.descriptiveNegativeName = "";
        inputAxis.negativeButton = negativeButton;
        inputAxis.positiveButton = positiveButton;
        inputAxis.altNegativeButton = altNegativeButton;
        inputAxis.altPositiveButton = altPositiveButton;
        inputAxis.gravity = gravity;
        inputAxis.dead = dead;
        inputAxis.sensitivity = sensitivity;
        inputAxis.snap = snap;
        inputAxis.invert = invert;
        inputAxis.type = type;
        inputAxis.axis = axis;
        inputAxis.joyNum = joyNum;
		return inputAxis;
    }
}

public class InputManagerGenerator
{
    private static SerializedObject serializedObject;
    private static SerializedProperty axesProperty;

    public InputManagerGenerator()
    {
        serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
        axesProperty = serializedObject.FindProperty("m_Axes");
    }

    public void AddAxis(InputAxis axis)
    {
        if (axis.axis < 1) Debug.LogError("Axisは1以上に設定してください。");
        SerializedProperty axesProperty = serializedObject.FindProperty("m_Axes");

        axesProperty.arraySize++;
        serializedObject.ApplyModifiedProperties();

        SerializedProperty axisProperty = axesProperty.GetArrayElementAtIndex(axesProperty.arraySize - 1);

        GetChildProperty(axisProperty, "m_Name").stringValue = axis.name;
        GetChildProperty(axisProperty, "descriptiveName").stringValue = axis.descriptiveName;
        GetChildProperty(axisProperty, "descriptiveNegativeName").stringValue = axis.descriptiveNegativeName;
        GetChildProperty(axisProperty, "negativeButton").stringValue = axis.negativeButton;
        GetChildProperty(axisProperty, "positiveButton").stringValue = axis.positiveButton;
        GetChildProperty(axisProperty, "altNegativeButton").stringValue = axis.altNegativeButton;
        GetChildProperty(axisProperty, "altPositiveButton").stringValue = axis.altPositiveButton;
        GetChildProperty(axisProperty, "gravity").floatValue = axis.gravity;
        GetChildProperty(axisProperty, "dead").floatValue = axis.dead;
        GetChildProperty(axisProperty, "sensitivity").floatValue = axis.sensitivity;
        GetChildProperty(axisProperty, "snap").boolValue = axis.snap;
        GetChildProperty(axisProperty, "invert").boolValue = axis.invert;
        GetChildProperty(axisProperty, "type").intValue = (int)axis.type;
        GetChildProperty(axisProperty, "axis").intValue = axis.axis - 1;
        GetChildProperty(axisProperty, "joyNum").intValue = axis.joyNum;

        serializedObject.ApplyModifiedProperties();
    }

    private SerializedProperty GetChildProperty(SerializedProperty parent, string name)
    {
        SerializedProperty child = parent.Copy();
        child.Next(true);
        do
        {
            if (child.name == name) return child;
        }
        while (child.Next(false));
        return null;
    }

    public void Clear()
    {
        axesProperty.ClearArray();
        serializedObject.ApplyModifiedProperties();
    }
}