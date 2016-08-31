using UnityEngine;
using System;
using System.Collections;

public class GeometryCalculator {

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
