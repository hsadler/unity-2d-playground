using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFactoryGameManager : MonoBehaviour
{

    public static TileFactoryGameManager instance { get; private set; }

    public GameObject gameTilePrefab;

    public static IDictionary<int[], GameObject> tiles;
    public int tilesWidth;
    public int tilesHeight;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // singleton pattern
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
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
