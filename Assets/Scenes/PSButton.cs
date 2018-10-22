public enum PSButton
{
    LDown,
    LRight,
    L1,
    L2,
    L3,
    RDown,
    RRight,
    R1,
    R2,
    R3,
    Circle,
    Rectangle,
    Triangle,
    Cross,
    Right,
    Up,
    None,
}

public static class PSButtonExtention
{
    public static string[] strings = {
        "LDown",
        "LRight",
        "L1",
        "L2",
        "L3",
        "RDown",
        "RRight",
        "R1",
        "R2",
        "R3",
        "Circle",
        "Rectangle",
        "Triangle",
        "Cross",
        "Right",
        "Up",
        "None"
    };
    public static string ToValue(this PSButton value)
    {
        var i = (int)value;
        if (i < strings.Length)
        {
            return strings[i];
        }
        else
        {
            return "none";
        }
    }
}