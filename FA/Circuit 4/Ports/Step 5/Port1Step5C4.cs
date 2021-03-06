using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port1Step5C4 : MonoBehaviour
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

        if(Port1Step4C4.isConnected) {
            connectedCables++;
        } else {
            connectedCables = 0;
        }

        posisiX = setPosisiX - (0.603f * connectedCables);
        posisiY = setPosisiY;
        posisiZ = setPosisiZ - (2.108f * connectedCables);
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
