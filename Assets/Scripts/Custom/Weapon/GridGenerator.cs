using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{

    public Grid grid;
    public GameObject hexagon;

    public int gridSize;

    private void Start()
    {
      //  GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int x = -gridSize; x < gridSize; x++)
        {
            for (int y = -gridSize; y < gridSize; y++) 
            { 
                Vector3 spawnPos = grid.CellToWorld(new Vector3Int(x, y, 0));
                Instantiate(hexagon, spawnPos, Quaternion.identity, transform);
            }
        }
    }
}
