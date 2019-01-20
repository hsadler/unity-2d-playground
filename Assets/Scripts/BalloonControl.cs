using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControl : MonoBehaviour
{
 
    public float pumpForceRate;
    public float pumpScaleRate;
    
    private bool doPump = false;

    // Update is called once per frame
    void Update()
    {
        if(doPump) {
            PumpBalloon();
        }
    }

    void PumpBalloon() {
        Transform t = transform;
        ConstantForce2D cf = gameObject.GetComponent<ConstantForce2D>();
        // scale balloon larger
        t.localScale += new Vector3(pumpScaleRate, pumpScaleRate, 0);
        // add upward force to balloon
        cf.force += new Vector2(0, pumpForceRate);
    }

    public void PumpOn() {
        doPump = true;
    }    

    public void PumpOff() {
        doPump = false;
    }

}
