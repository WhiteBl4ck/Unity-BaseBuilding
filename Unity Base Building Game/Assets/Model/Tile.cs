using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile  {

    public enum TileType { Empty, Floor };

    TileType type = TileType.Empty;


    World world;
    int x;
    int y;

    public TileType Type
    {
        get
        {
            return type;
        }
       
    }

    public Tile(World world, int x, int y)
    {
        this.world = world;
        this.x = x;
        this.y = y;
    }
}
