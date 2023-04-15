using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon
{
    public int Width;
    public int Height;
    decimal[,] Vertices;

    public Polygon(int width, int height, decimal[,] vertices)
    {
        Width = width;
        Height = height;
        Vertices = vertices;
    }
}

