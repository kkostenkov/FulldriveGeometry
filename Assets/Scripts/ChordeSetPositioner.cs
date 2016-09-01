using UnityEngine;
using System.Collections;
using System;

public class ChordeSetPositioner : MonoBehaviour {
    [SerializeField] private LineRenderer chordeLine;
    [SerializeField] private LineRenderer offsetLine;

    internal void Initialize(int setNumber, ChordePacker data)
    {
        float radius = data.Radius;
        float angle = setNumber * (data.ChordeAngle + data.OffsetAngle);
        chordeLine.SetPosition(0, RotatedPointCoords(angle, radius));
        angle += data.ChordeAngle;
        chordeLine.SetPosition(1, RotatedPointCoords(angle, radius));
        offsetLine.SetPosition(0, RotatedPointCoords(angle, radius));
        angle += data.OffsetAngle;
        offsetLine.SetPosition(1, RotatedPointCoords(angle, radius));
    }

    private Vector3 RotatedPointCoords(float angle, float radius)
    {
        var y = Math.Sin(angle);
        var x = Math.Cos(angle);
        return new Vector3((float)x, (float)y, 0);
    }
    


}
