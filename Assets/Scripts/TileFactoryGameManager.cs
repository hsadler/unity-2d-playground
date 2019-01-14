using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFactoryGameManager : MonoBehaviour
{

    public GameObject gameTilePrefab;

    public static IDictionary<int[], GameObject> tiles;
    public int tilesWidth;
    public int tilesHeight;

    // Start is called before the first frame update
    void Start()
    {
        // proceedurally generate the game tiles
        for (int y = -tilesHeight; y < tilesHeight; y++)
        {
            for (int x = -tilesWidth; x < tilesWidth; x++)
            {
                Vector3 position = new Vector3(x, y, 0);
                Instantiate(gameTilePrefab, position, transform.rotation);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
