using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        //Circuit7.isGreen = true;
    }

    private void OnTriggerExit(Collider other) {
        //Circuit7.isGreen = false;
    }
}
