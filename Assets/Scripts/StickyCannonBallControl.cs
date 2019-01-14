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

            Vector3 scale = transform.localScale;
            Vector3 position = transform.localPosition;
            transform.SetParent(stickyBallParent.transform);
            // prevent the transform of the sticky cannonball from inheriting from the new parent
            transform.localScale = scale;
            transform.localPosition = position;
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Collider2D col = GetComponent<Collider2D>();
            Destroy(rb);
            // Destroy(col);
            // rb.isKinematic = true;
            isStuck = true;
        }
    }

}
