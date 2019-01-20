using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTriggerControl : MonoBehaviour
{

    private HingeJoint2D plankJoint;
    private HingeJoint2D groundJoint;

    // Start is called before the first frame update
    void Start()
    {
        HingeJoint2D[] hjs = GetComponents<HingeJoint2D>();
        plankJoint = hjs[0];
        groundJoint = hjs[1];
    }

    public void ReleaseTrigger() {
        Destroy(plankJoint);
    }

}
