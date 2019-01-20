using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PumpBalloonButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public GameObject balloon;
    
    public void OnPointerDown(PointerEventData eventData) {
        balloon.GetComponent<BalloonControl>().PumpOn();
    }

    public void OnPointerUp(PointerEventData eventData) {
        balloon.GetComponent<BalloonControl>().PumpOff();
    }

}
