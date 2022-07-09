using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedEsca2 : MonoBehaviour
{
    public GameObject[] tiles;

    public int[,] map = new int[,]
    {
        {00, 02},
        {00, 02},
        {03, 01},

    };
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateMap()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                int tileIndex = map[row, col];
                GameObject newTile = Instantiate(tiles[tileIndex], transform);

                newTile.transform.position = new Vector3(col * 3f, 0, row * 3f);
            }
        }
    }
}
