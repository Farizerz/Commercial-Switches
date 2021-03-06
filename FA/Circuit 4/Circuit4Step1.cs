using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit4Step1 : MonoBehaviour
{
    [Header("Game Object")]
    public GameObject[] cable;
    public GameObject[] collider;

    [Header("Modifier")]
    public static bool Step1C4Done;
    public bool port1Done;
    public bool port2Done;
    public Vector3 AlignConnector1;
    public Vector3 AlignConnector2;


    // Start is called before the first frame update
    void Start()
    {
        Step1C4Done = false;
        AlignConnector1 = cable[0].transform.localEulerAngles;
        AlignConnector2 = cable[1].transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //port 1
        if(Port1Step1C4.connectedCableName == "Kabel 1" && !Port1Step1C4.isDragging) {
            cable[0].transform.localPosition = new Vector3(Port1Step1C4.posisiX, Port1Step1C4.posisiY, Port1Step1C4.posisiZ);
            cable[0].GetComponent<Collider>().enabled = false;
            cable[0].transform.localEulerAngles = AlignConnector1;
            collider[0].SetActive(false);
            port1Done = true;
        }

        else if(Port1Step1C4.connectedCableName == "Kabel 2" && !Port1Step1C4.isDragging) {
            cable[1].transform.localPosition = new Vector3(Port1Step1C4.posisiX, Port1Step1C4.posisiY, Port1Step1C4.posisiZ);
            cable[1].GetComponent<Collider>().enabled = false;
            cable[1].transform.localEulerAngles = AlignConnector1;
            collider[0].SetActive(false);
            port1Done = true;
        }

        //port 2
        if(Port2Step1C4.connectedCableName == "Kabel 1" && !Port2Step1C4.isDragging) {
            cable[0].transform.localPosition = new Vector3(Port2Step1C4.posisiX, Port2Step1C4.posisiY, Port2Step1C4.posisiZ);
            cable[0].GetComponent<Collider>().enabled = false;
            cable[0].transform.localEulerAngles = AlignConnector2;
            collider[1].SetActive(false);
            port2Done = true;
        }
        if(Port2Step1C4.connectedCableName == "Kabel 2" && !Port2Step1C4.isDragging) {
            cable[1].transform.localPosition = new Vector3(Port2Step1C4.posisiX, Port2Step1C4.posisiY, Port2Step1C4.posisiZ);
            cable[1].GetComponent<Collider>().enabled = false;
            cable[1].transform.localEulerAngles = AlignConnector2;
            collider[1].SetActive(false);
            port2Done = true;
        }          

        //selesaikan step ketika kedua port terhubung
        if(port1Done && port2Done) {
            Step1C4Done = true;
        }     

    }
}
