using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] public GameObject poly;
    //этот лист тебе не нужен. Потом передай сюда свой.
    public List<IPolygon> tiles = new List<IPolygon>();
    //и это тоже тебе не надо
    decimal[,] vertices = new decimal[4, 2];
    decimal[,] vertices2 = new decimal[4, 2];
    decimal[,] vertices3 = new decimal[4, 2];

    void Start()
    {
        //сюда в качестве аргумента передай свой лист
        Spawner(tiles);
    }

    public void Spawner(List<IPolygon> polygons)
    {
        //это просто для теста. Можешь удалить.
        vertices[0, 0] = 0; vertices2[0, 0] = -1; vertices3[0, 0] = 0;
        vertices[0, 1] = 2; vertices2[0, 1] = 2; vertices3[0, 1] = 0;

        vertices[1, 0] = 2; vertices2[1, 0] = 1; vertices3[1, 0] = 2;
        vertices[1, 1] = 2; vertices2[1, 1] = 2; vertices3[1, 1] = 0;

        vertices[2, 0] = 2; vertices2[2, 0] = 2; vertices3[2, 0] = 2;
        vertices[2, 1] = 0; vertices2[2, 1] = 0; vertices3[2, 1] = -2;

        vertices[3, 0] = 0; vertices2[3, 0] = -1; vertices3[3, 0] = 0;
        vertices[3, 1] = 0; vertices2[3, 1] = 0; vertices3[3, 1] = -2;

        tiles.Add(new Polygon(vertices));
        tiles.Add(new Polygon(vertices2));
        tiles.Add(new Polygon(vertices3));

        //тут размещаем все зоны.
        for (int i = 0; i < polygons.Count; i++)
        {
            GameObject temp = Instantiate(poly);
            temp.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.Range(0, 255) / 100, UnityEngine.Random.Range(0, 255) / 100, UnityEngine.Random.Range(0, 255) / 100, 1);
            temp.transform.localScale = new Vector3((float)(Math.Abs(polygons[i].Vertices[0, 0]) + Math.Abs(polygons[i].Vertices[1, 0])), (float)(Math.Abs(polygons[i].Vertices[1, 1]) + Math.Abs(polygons[i].Vertices[2, 1])), 1);
            temp.transform.position = new Vector3((float)((polygons[i].Vertices[0, 0] + polygons[i].Vertices[1, 0]) / 2), (float)((polygons[i].Vertices[1, 1] + polygons[i].Vertices[2, 1]) / 2));
        }
    }
}
