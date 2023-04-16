using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : IPolygon
{
    public Polygon(IPolygon polygon)
    {
        Vertices = polygon.Vertices;
    }

    public Polygon(decimal[,] vertices)
    {
        Vertices = vertices;
    }

    public int ID { get; }

    public int Width { get; }

    public int Height { get; }

    public decimal[] Center { get;  }

    public decimal[,] Vertices { get; }

    public void Move(decimal centerDeltaX, decimal centerDeltaY)
    {
        throw new System.NotImplementedException();
    }

    public void Rotate(int angle)
    {
        throw new System.NotImplementedException();
    }
}

