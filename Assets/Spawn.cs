using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //этот лист тебе не нужен. Потом передай сюда свой.
    public List<IPolygon> tiles = new List<IPolygon>();
    //и это тоже тебе не надо
    decimal[,] vertices = new decimal[4, 2];

    void Start()
    {
        //сюда в качестве аргумента передай свой лист
        Spawner(tiles);
    }

    public void Spawner(List<IPolygon> polygons)
    {
        //это просто для теста. Можешь удалить.
        vertices[0, 0] = 0;
        vertices[0, 1] = 2;

        vertices[1, 0] = 2;
        vertices[1, 1] = 2;

        vertices[2, 0] = 2;
        vertices[2, 1] = 0;

        vertices[3, 0] = 0;
        vertices[3, 1] = 0;


        tiles.Add(new Polygon(vertices));

        //тут размещаем все зоны.
        for (int i = 0; i < polygons.Count; i++)
        {
            ((Polygon)polygons[i]).tile.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 255) / 100, Random.Range(0, 255) / 100, Random.Range(0, 255) / 100, 1);
            ((Polygon)polygons[i]).tile.transform.localScale = new Vector3((float)(polygons[i].Vertices[0, 0] + polygons[i].Vertices[1, 0]), (float)(polygons[i].Vertices[1, 1] + polygons[i].Vertices[2, 1]), 1);
            ((Polygon)polygons[i]).tile.transform.position = new Vector3((float)((polygons[i].Vertices[0, 0] + polygons[i].Vertices[1, 0]) / 2), (float)((polygons[i].Vertices[1, 1] + polygons[i].Vertices[2, 1]) / 2));
        }
    }
}
