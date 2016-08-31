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
    public float OffsetLength
    {
        get { return chordeLength * OFFSET_MODIFIER; }
    }


    public void PackChordsToCircle(float radius_, float chordeLength_)
    {
        radius = radius_;
        chordeLength = chordeLength_;
        GeometryCalculator calc = new GeometryCalculator();
        float chordeCurve = (float)calc.CalculateChordeCurve(radius, chordeLength);
        float offestLength = chordeLength * OFFSET_MODIFIER;
        //SceneDirector.Instance.Print(offestLength.ToString());
        float offsetCurve = (float)calc.CalculateChordeCurve(radius, offestLength);
        //SceneDirector.Instance.Print(offsetCurve.ToString());
        //SceneDirector.Instance.ShowResult(chordeCurve.ToString() + " " + offsetCurve.ToString());
        float setLength = chordeCurve + offsetCurve;
        SceneDirector.Instance.Print("Set Length is " + setLength.ToString());
        float circlePerimeter = calc.CalculateCirclePerimeter(radius);
        SceneDirector.Instance.Print("Circle perimeter is " + circlePerimeter.ToString());
        setsPackedCount = (int)(circlePerimeter / setLength);
        SceneDirector.Instance.ReportResult(this);
    }
}
