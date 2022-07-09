using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso1 : MonoBehaviour
{
    public GameObject[] tiles;

    public int[,] map = new int[,]
    {
        {07, 01, 07, 01, 07, 01, 01, 08, 01, 00, 00, 07, 01, 01, 01, 01, 01, 01, 01, 08 },
        {04, 00, 04, 00, 00, 00, 00, 03, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 04, 00, 00, 00, 00, 03, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {05, 00, 05, 02, 05, 02, 00, 06, 00, 00, 00, 05, 02, 02, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 03, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 03, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 07, 07, 01, 07, 01, 07, 01, 01, 08 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 05, 00, 05, 00, 04, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 04, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 07, 00, 04, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 05, 02, 02, 05, 02, 05, 00, 02, 06 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 07, 01, 01, 00, 01, 01, 08 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 03 },
        {04, 00, 00, 00, 00, 00, 03, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 03 },
        {05, 02, 02, 02, 02, 02, 06, 02, 02, 02, 02, 02, 02, 04, 00, 00, 00, 00, 00, 03 },
        {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 05, 02, 02, 02, 00, 00, 03 },
        {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 03 },
        {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 04, 00, 00, 00, 00, 00, 03 },
        {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 05, 02, 02, 02, 02, 02, 06 },

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
        for (int row = 0; row < 27; row++)
        {
            for (int col = 0; col < 20; col++)
            {
                int tileIndex = map[row, col];
                GameObject newTile = Instantiate(tiles[tileIndex], transform);

                newTile.transform.position = new Vector3(col * 3f, 0, row * -3f);
            }
        }
    }
}