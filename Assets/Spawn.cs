using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //твои зоны
    [SerializeField] public GameObject tile1;
    public List<IPolygon> tiles = new List<IPolygon>();
    decimal[,] vertices = new decimal[4, 2];

    void Start()
    {
        Spawner();
    }

    public void Spawner()
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
        for (int i = 0; i < tiles.Count; i++)
        {
            tile1.transform.localScale = new Vector3((float)(tiles[i].Vertices[0, 0] + tiles[i].Vertices[1, 0]), (float)(tiles[i].Vertices[1, 1] + tiles[i].Vertices[2, 1]));
            tile1.transform.position = new Vector3((float)((tiles[i].Vertices[0, 0] + tiles[i].Vertices[1, 0]) / 2), (float)((tiles[i].Vertices[1, 1] + tiles[i].Vertices[2, 1]) / 2));
        }
    }
}
