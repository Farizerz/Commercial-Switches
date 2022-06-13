using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject ParentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Asu");
        Instantiate(ParentPrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
