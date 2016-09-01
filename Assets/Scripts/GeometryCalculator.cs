using System;

public class GeometryCalculator {

    public double CalculateCenterAngle(float radius, float chordeLength)
    {
        // Chorde with two radiuses are Isosceles traingle.
        double cosB = CalculateIsoscelesSharpCosine(radius, chordeLength);
        double radiansB = CosineToRadians(cosB);
        double radiansA = Math.PI - radiansB * 2;
        return radiansA;
    }

    public double CalculateChordeCurve(float radius, float chordeLength)
    {
        // Chorde with two radiuses are Isosceles traingle.
        double cosB = CalculateIsoscelesSharpCosine(radius, chordeLength);
        double radiansB = CosineToRadians(cosB);
        double radiansA = Math.PI - radiansB * 2;
        double chordeCurveLength = CalculateChordeCurveLength(radiansA, radius);
        return chordeCurveLength;
    }

    /// <summary>
    /// Calculates cos of central angle (between legs) from traingle side lengths.
    /// </summary>
    /// <param name="a">Leg length.</param>
    /// <param name="b">Base length.</param>
    public double CalculateIsoscelesSharpCosine(float legLength, float baseLength) 
    {
        double cosB = baseLength / (2 * legLength);
        return cosB;   
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
