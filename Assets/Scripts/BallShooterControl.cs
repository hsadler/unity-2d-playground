using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooterControl : MonoBehaviour
{

    public float thrust;
    public float torque;

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
    }
}
