using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    
    public GameObject cratePink;
    public int waitSeconds;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("WaitAndSpawnCrate", 0.0f, 0.5f);
    }

    void WaitAndSpawnCrate()
    {
        Instantiate(cratePink, transform.position, transform.rotation, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
