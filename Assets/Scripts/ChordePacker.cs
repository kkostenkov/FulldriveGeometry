using UnityEngine;
using System.Collections;

public class ChordePacker {
    public static float OFFSET_MODIFIER = 0.2f;
    

    public void PackChordsToCircle(float radius, float chordeLength)
    {
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
        int setsPackedCount = (int)(circlePerimeter / setLength);

        SceneDirector.Instance.ShowResult(setsPackedCount.ToString() + " sets packed.");

    }
}
