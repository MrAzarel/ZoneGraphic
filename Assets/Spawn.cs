using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //твои зоны
    [SerializeField] public GameObject tile1;
    public Polygon[] tiles = new Polygon[1];
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


        tiles[0] = new Polygon(2, 2, vertices);

        //тут размещаем все зоны.
        for (int i = 0; i < tiles.Length; i++)
        {
            tile1.transform.localScale = new Vector3(tiles[i].Width, tiles[i].Height);
            tile1.transform.position = new Vector3((float)((vertices[0, 0] + vertices[1, 0]) / 2), (float)((vertices[1, 1] + vertices[2, 1]) / 2));
        }
    }
}
