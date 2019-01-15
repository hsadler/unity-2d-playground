using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyCannonBallControl : MonoBehaviour
{
    
    private bool isStuck = false;

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(!isStuck) {
            GameObject stickyBallParent = new GameObject("StickyBallParent");
            stickyBallParent.transform.SetParent(other.transform);
            transform.SetParent(stickyBallParent.transform);
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Destroy(rb);
            isStuck = true;
        }
    }

}
