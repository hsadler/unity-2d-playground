using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawnControl : MonoBehaviour
{
    
    public GameObject stickyCannonBall;
    public float cannonPower;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            GameObject newCannonBall = Instantiate(
                stickyCannonBall, 
                transform.position, 
                transform.rotation
            );
            newCannonBall.GetComponent<Rigidbody2D>().AddForce(transform.right * cannonPower);
        }   
    }
}
