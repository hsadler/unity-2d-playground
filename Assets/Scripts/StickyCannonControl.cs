using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyCannonControl : MonoBehaviour
{
    
    public float rotationSensitivity;
    public GameObject reticle;
    public float tunedAimOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // OLD: by mouse up and down
        // float mouseY = Input.GetAxis("Mouse Y");
        // transform.Rotate(Vector3.forward * mouseY * rotationSensitivity, Space.World);

        // NEW: by looking at aim reticle
        transform.right = reticle.transform.position - transform.position;

    }

}
