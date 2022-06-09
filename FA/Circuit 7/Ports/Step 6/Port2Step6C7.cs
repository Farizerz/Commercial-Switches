using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port2Step6C7 : MonoBehaviour
{
    public float setPosisiX, setPosisiY, setPosisiZ;

    public static float posisiX, posisiY, posisiZ;

    public static bool isDragging, isConnected;
    public static string connectedCableName;

    public static int connectedCables;
    public int cons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cons = connectedCables;
        Debug.Log(cons);
    }

    void OnTriggerEnter(Collider collider) {
        if(Port2Step4C7.isConnected) {
            connectedCables++;
        } else {
            connectedCables = 0;
        }
        posisiX = setPosisiX - (0.6f * connectedCables);
        posisiY = setPosisiY;
        posisiZ = setPosisiZ - (2.1f * connectedCables);
        isConnected = true;
        connectedCableName = collider.gameObject.name;
    }

    private void OnTriggerExit(Collider other) {
        //collider.gameObject.transform.position = new Vector3(posisiX, posisiY, posisiZ);
        isConnected = false;
        connectedCableName = "";
        connectedCables--;
    }
}
