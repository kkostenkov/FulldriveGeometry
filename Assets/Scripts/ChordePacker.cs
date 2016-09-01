using System;

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
        if (radius_ * 2 < chordeLength_ ||
            radius_ <= 0 ||
            chordeLength_ <= 0)
        {
            SceneDirector.Instance.ShowInputWarning();
            return;
        }
        radius = radius_;
        chordeLength = chordeLength_;
        GeometryCalculator calc = new GeometryCalculator();
        chordeAngle = (float)calc.CalculateCenterAngle(radius, chordeLength);
        offestLength = chordeLength * OFFSET_MODIFIER;
        offsetAngle = (float)calc.CalculateCenterAngle(radius, offestLength);
        double quotient = 2 * Math.PI / (offsetAngle + chordeAngle);
        setsPackedCount = (int)Math.Floor(quotient);
        SceneDirector.Instance.ReportResult(this);
    }
}
