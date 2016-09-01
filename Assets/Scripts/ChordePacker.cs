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
        float chordeCurve = (float)calc.CalculateChordeCurveLength(chordeAngle, radius);
        offestLength = chordeLength * OFFSET_MODIFIER;
        offsetAngle = (float)calc.CalculateCenterAngle(radius, offestLength);
        float offsetCurve = (float)calc.CalculateChordeCurveLength(offsetAngle, radius);
        float setLength = chordeCurve + offsetCurve;
        float circlePerimeter = calc.CalculateCirclePerimeter(radius);
        setsPackedCount = (int)(circlePerimeter / setLength);
        SceneDirector.Instance.ReportResult(this);
    }
}
