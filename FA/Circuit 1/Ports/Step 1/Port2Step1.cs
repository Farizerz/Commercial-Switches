﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port2Step1 : MonoBehaviour
{
    public float setPosisiX, setPosisiY, setPosisiZ;

    public static float posisiX, posisiY, posisiZ;

    public static bool isDragging, isConnected;
    public static string connectedCableName;

    public static int connectedCables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider) {
        posisiX = setPosisiX - (0.63f * connectedCables);
        posisiY = setPosisiY;
        posisiZ = setPosisiZ - (2.23f * connectedCables);
        isConnected = true;
        connectedCableName = collider.gameObject.name;
        connectedCables++;
    }

    private void OnTriggerExit(Collider other) {
        //collider.gameObject.transform.position = new Vector3(posisiX, posisiY, posisiZ);
        isConnected = false;
        connectedCableName = "";        
        connectedCables--;
    }
}
