using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltBehaviour : MonoBehaviour
{

    public float beltForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Sent each frame where another object is within a trigger collider
    /// attached to this object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerStay2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.right * beltForce);
    }

}
