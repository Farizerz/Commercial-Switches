using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Circuit7Buttons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    public bool show;
    // Start is called before the first frame update
    void Start()
    {
        show = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(show) {
            Debug.Log("Hantuuuu!");
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        show = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        show = false;
    }
}
