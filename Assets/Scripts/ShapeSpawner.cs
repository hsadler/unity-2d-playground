using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{

    public float spawnFrequency;
    public float torqueAmount;
    public GameObject trianglePrefab;
    public GameObject squarePrefab;

    void Start()
    {
        InvokeRepeating("WaitAndSpawnShape", 0.0f, spawnFrequency);
    }

    void WaitAndSpawnShape()
    {
        GameObject newShape;
        if(Random.value > 0.5f) {
           newShape = Instantiate(trianglePrefab, transform.position, transform.rotation, transform);
        } else {
            newShape = Instantiate(squarePrefab, transform.position, transform.rotation, transform);
        }
        newShape.GetComponent<Rigidbody2D>().AddTorque(torqueAmount);
    }
}
