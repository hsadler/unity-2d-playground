using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooterControl : MonoBehaviour
{

    public float thrust;
    public float torque;

    public GameObject ballSpawner;
    public GameObject ball;
    public float ballFirePower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            GetComponent<Rigidbody2D>().AddForce(transform.up * thrust);
        }
        if(Input.GetKey(KeyCode.S)) {
            GetComponent<Rigidbody2D>().AddForce(transform.up * -thrust);
        }
        if(Input.GetKey(KeyCode.A)) {
            GetComponent<Rigidbody2D>().AddTorque(torque);
        }
        if(Input.GetKey(KeyCode.D)) {
            GetComponent<Rigidbody2D>().AddTorque(-torque);
        }
        if(Input.GetKeyDown(KeyCode.Space)) {
            GameObject newBall = Instantiate(
                ball, 
                ballSpawner.transform.position, 
                ballSpawner.transform.rotation, 
                ballSpawner.transform
            );
            Rigidbody2D newBallRB = newBall.GetComponent<Rigidbody2D>();
            newBallRB.velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
            newBallRB.GetComponent<Rigidbody2D>().AddForce(ballSpawner.transform.up * ballFirePower);
        }
    }
}
