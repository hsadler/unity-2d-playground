using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("WaitAndSpawnBall", 0.0f, 0.5f);
    }

    void WaitAndSpawnBall()
    {
        GameObject newBall = Instantiate(ball, transform.position, transform.rotation, transform);
        Rigidbody2D rb2d = newBall.GetComponent<Rigidbody2D>();
        float randX = Random.value * 10.0f + 5.0f;
        if(Random.value > 0.5f) {
            randX = randX * -1.0f;
        }
        float randY = Random.value * 10.0f + 5.0f;
        if(Random.value > 0.5f) {
            randY = randY * -1.0f;
        }
        Vector2 v2d = new Vector2(randX, randY);
        rb2d.AddForce(v2d);
    }
}
