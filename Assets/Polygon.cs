using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : IPolygon
{
    public GameObject tile;

    public Polygon(IPolygon polygon, string num)
    {
        if (num == "0")
        {
            tile = GameObject.Find("Cube");
        }
        else
            tile = GameObject.Find("Cube (" + num + ")");
        Vertices = polygon.Vertices;
    }

    public Polygon(decimal[,] vertices, string num)
    {
        if (num == "0")
        {
            tile = GameObject.Find("Cube");
        }
        else
            tile = GameObject.Find("Cube (" + num + ")");
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

