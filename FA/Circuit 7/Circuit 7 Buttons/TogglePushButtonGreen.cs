using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TogglePushButtonGreen : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData) {
        Circuit7.isGreen = true;
        
    }

    public void OnPointerUp(PointerEventData eventData) {        
        Circuit7.isGreen = false;
    }


}
