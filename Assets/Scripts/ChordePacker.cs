using UnityEngine;
using System.Collections;

public class ChordePacker {
    private static float OFFSET_MODIFIER = 0.2f;
    private int setsPackedCount;
    public int SetsPackedCount
    {
        get { return setsPackedCount; }
    }
    private float radius;
    public float Radius
    {
        get { return radius; }
    }
    private float chordeLength;
    public float ChordeLength
    {
        get { return chordeLength; }
    }
    private float offestLength;
    public float OffsetLength
    {
        get { return offestLength; }
    }

    private float chordeAngle;
    public float ChordeAngle
    {
        get
        {
            return chordeAngle;
        }
    }
    private float offsetAngle;
    public float OffsetAngle
        {
        get { return offsetAngle;
        }
    }


    public void PackChordsToCircle(float radius_, float chordeLength_)
    {
        radius = radius_;
        chordeLength = chordeLength_;
        GeometryCalculator calc = new GeometryCalculator();
        chordeAngle = (float)calc.CalculateCenterAngle(radius, chordeLength);
        SceneDirector.Instance.Print("Chorde angle is " + chordeAngle.ToString());
        float chordeCurve = (float)calc.CalculateChordeCurveLength(chordeAngle, radius);
        SceneDirector.Instance.Print("Chorde curve is " + chordeCurve.ToString());
        offestLength = chordeLength * OFFSET_MODIFIER;
        offsetAngle = (float)calc.CalculateCenterAngle(radius, offestLength);
        SceneDirector.Instance.Print("Offset angle is " + offsetAngle.ToString());
        float offsetCurve = (float)calc.CalculateChordeCurveLength(offsetAngle, radius);
        SceneDirector.Instance.Print("Offset curve is " + offsetCurve.ToString());
        float setLength = chordeCurve + offsetCurve;
        SceneDirector.Instance.Print("Set Length is " + setLength.ToString());
        float circlePerimeter = calc.CalculateCirclePerimeter(radius);
        SceneDirector.Instance.Print("Circle perimeter is " + circlePerimeter.ToString());
        setsPackedCount = (int)(circlePerimeter / setLength);
        SceneDirector.Instance.ReportResult(this);
    }
}
