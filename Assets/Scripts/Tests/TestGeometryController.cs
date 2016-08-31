using UnityEngine;
using UnityEngine.Assertions;
using System;
using System.Collections;

public class TestGeometryController : MonoBehaviour {
	
	void Start () {
        //TestAngles();
        //TestChordeCurve();
    }

    private void TestChordeCurve()
    {
        GeometryCalculator calc = new GeometryCalculator();
        double chordeCurve = calc.CalculateChordeCurve(2f, 2.8284f);
        Assert.AreApproximatelyEqual(3.14f, (float)chordeCurve);

        chordeCurve = calc.CalculateChordeCurve(5f, 2.59f);
        Assert.AreApproximatelyEqual(2.62f, (float)chordeCurve);

        chordeCurve = calc.CalculateChordeCurve(15.5f, 4.05f);
        Assert.AreApproximatelyEqual(4.06f, (float)chordeCurve);

    }

    private void TestAngles()
    {
        // Angles
        double degrees = CalcSharpAngle(2, 2.8284f);
        Assert.AreApproximatelyEqual(45f, (float)degrees);

        degrees = CalcCentralAngle(2, 2.8284f);
        Assert.AreApproximatelyEqual(90f, (float)degrees);

        degrees = CalcCentralAngle(5, 8);
        Assert.AreApproximatelyEqual(106.26f, (float)degrees);
    }
	
	private double CalcSharpAngle(float legLength, float baseLength)
    {
        GeometryCalculator calc = new GeometryCalculator();
        double cosB = calc.CalculateIsoscelesSharpCosine(legLength, baseLength);
        double radiansB = calc.CosineToRadians(cosB);
        double degreesB = radiansB * 57.2958f;
        print("degrees " + degreesB);
        return degreesB;
    }

    private double CalcCentralAngle(float legLength, float baseLength)
    {
        double degreesB = CalcSharpAngle(legLength, baseLength);
        double degreesA = 180f - 2 * degreesB;
        print("degrees A = " + degreesA);
        return degreesA;
    }
}
