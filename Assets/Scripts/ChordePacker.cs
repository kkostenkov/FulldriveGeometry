using UnityEngine;
using System.Collections;

public class ChordePacker {
    public static float OFFSET_MODIFIER = 0.2f;
    

    public void PackChordsToCircle(float radius, float chordeLength)
    {
        GeometryCalculator calc = new GeometryCalculator();
        double chordeCurve = calc.CalculateChordeCurve(radius, chordeLength);
        float offestLength = chordeLength * OFFSET_MODIFIER;
        SceneDirector.Instance.Print(offestLength.ToString());
        double offsetCurve = calc.CalculateChordeCurve(radius, offestLength);
        SceneDirector.Instance.Print(offsetCurve.ToString());
        SceneDirector.Instance.ShowResult(chordeCurve.ToString() + " " + offsetCurve.ToString());
    }
}
