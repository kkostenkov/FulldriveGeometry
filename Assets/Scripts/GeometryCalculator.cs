using UnityEngine;
using System;
using System.Collections;

public class GeometryCalculator {

    public double CalculateChordeCurve(float radius, float chordeLength)
    {
        // Chorde with two radiuses are Isosceles traingle.
        double cosA = CalculateIsoscelesCentralCosine(radius, chordeLength);
        double radiansA = CosineToRadians(cosA);
        double chordeCurveLength = CalculateChordeCurveLength(radiansA, radius);
        return chordeCurveLength;
    }

    /// <summary>
    /// Calculates cos of central angle (between legs) from traingle side lengths.
    /// </summary>
    /// <param name="a">Leg length.</param>
    /// <param name="b">Base length.</param>
    public double CalculateIsoscelesCentralCosine(float legLength, float baseLength) 
    {
        return CalculateCosine(legLength, legLength, baseLength);
    }

    /// <summary>
    /// Calculates cos of central angle (between sides "b" and "c") from traingle side lengths.
    /// Based on Law of Cosine https://en.wikipedia.org/wiki/Law_of_cosines
    /// </summary>
    /// <returns></returns>
    public double CalculateCosine(float a, float b, float c)
    {
        double cosAlpha = b / (2 * a);
        return cosAlpha;
    }

    public double CosineToRadians(double cosine)
    {
        double radians = Math.Acos(cosine);
        return radians;
    }

    /// <summary>
    /// Calculates length of chorde inside circle.
    /// </summary>
    /// <param name="radians">Central angle</param>
    /// <param name="radius">Circle radius</param>
    public double CalculateChordeCurveLength(double radians, float radius)
    {
        return radians * radius;
    }

    /// <summary>
    /// l = 2 * Pi * r
    /// </summary>
    /// <param name="radius">Circle radius</param>
    public float CalculateCirclePerimeter(float radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius should be greater than 0.");
        float result = 2 * (float)Math.PI * radius;
        return result;
    }

    
}
