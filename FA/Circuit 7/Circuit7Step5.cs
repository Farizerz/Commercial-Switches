﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit7Step5 : MonoBehaviour
{
    [Header("Game Object")]
    public GameObject[] cable;
    public GameObject[] collider;

    [Header("Modifier")]
    public static bool Step5C7Done;
    public bool port1Done;
    public bool port2Done;
    public Vector3 AlignConnector1;
    public Vector3 AlignConnector2;

    // Start is called before the first frame update
    void Start()
    {
        Step5C7Done = false;
        AlignConnector1 = cable[0].transform.localEulerAngles;
        AlignConnector2 = cable[1].transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //port 1
        if(Port1Step5C7.connectedCableName == "Kabel 1" && !Port1Step5C7.isDragging) {
            cable[0].transform.localPosition = new Vector3(Port1Step5C7.posisiX, Port1Step5C7.posisiY, Port1Step5C7.posisiZ);
            cable[0].GetComponent<Collider>().enabled = false;
            cable[0].transform.localEulerAngles = AlignConnector1;
            collider[0].SetActive(false);
            port1Done = true;
        }

        else if(Port1Step5C7.connectedCableName == "Kabel 2" && !Port1Step5C7.isDragging) {
            cable[1].transform.localPosition = new Vector3(Port1Step5C7.posisiX, Port1Step5C7.posisiY, Port1Step5C7.posisiZ);
            cable[1].GetComponent<Collider>().enabled = false;
            cable[1].transform.localEulerAngles = AlignConnector1;
            collider[0].SetActive(false);
            port1Done = true;
        }

        //port 2
        if(Port2Step5C7.connectedCableName == "Kabel 1" && !Port2Step5C7.isDragging) {
            cable[0].transform.localPosition = new Vector3(Port2Step5C7.posisiX, Port2Step5C7.posisiY, Port2Step5C7.posisiZ);
            cable[0].GetComponent<Collider>().enabled = false;
            cable[0].transform.localEulerAngles = AlignConnector2;
            collider[1].SetActive(false);
            collider[2].SetActive(false);
            port2Done = true;
        }
        if(Port2Step5C7.connectedCableName == "Kabel 2" && !Port2Step5C7.isDragging) {
            cable[1].transform.localPosition = new Vector3(Port2Step5C7.posisiX, Port2Step5C7.posisiY, Port2Step5C7.posisiZ);
            cable[1].GetComponent<Collider>().enabled = false;
            cable[1].transform.localEulerAngles = AlignConnector2;
            collider[1].SetActive(false);
            collider[2].SetActive(false);
            port2Done = true;
        }          

        //selesaikan step ketika kedua port terhubung
        if(port1Done && port2Done) {
            Step5C7Done = true;
        }     

    }
}
