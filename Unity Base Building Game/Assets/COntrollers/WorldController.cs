using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

    World world;
	// Use this for initialization
	void Start () {
        world = new World();
        for (int i = 0; i < world.Width; i++)
        {
            for (int j = 0; j < world.Height; j++)
            {
                GameObject tile_go = new GameObject();
                tile_go.name = "Tile_" + i + "_" + j;
                SpriteRenderer tile_sr = tile_go.AddComponent<SpriteRenderer>();

                 
            }
        }

        // Create 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
