using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World  {

    Tile[,] tiles;
    int width;
    int height;

    public int Width
    {
        get { return width; }
    }

    public int Height
    {
        get { return width; }

    }

    public World(int width = 100, int height = 100)
    {
        this.width = width;
        this.height = height;
        tiles = new Tile[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                tiles[i, j] = new Tile(this, i, j);
            }
        }
        Debug.Log("World created with " + width * height + " tiles");

    }

    public Tile GetTileAt ( int x, int y)
    {
        if(x > width || x < 0 || y > height || y < 0)
        {
            Debug.Log("Tile is out of range");
            return null;
        }
        return tiles[x, y];

    }
}
