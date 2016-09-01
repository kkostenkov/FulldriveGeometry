using System;

public class GeometryCalculator {

    public double CalculateCenterAngle(float radius, float chordeLength)
    {
        // Chorde with two radiuses are Isosceles traingle.
        double cosB = CalculateIsoscelesSharpCosine(radius, chordeLength);
        double radiansB = CosineToRadians(cosB);
        // Angles b & c are eaqual (isosceles). Sum of 3 angles = Pi.
        double radiansA = Math.PI - radiansB * 2;
        return radiansA;
    }

    /// <summary>
    /// Calculates cos of base angle from traingle side lengths.
    /// By the Law of cosines https://en.wikipedia.org/wiki/Law_of_cosines
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
}
