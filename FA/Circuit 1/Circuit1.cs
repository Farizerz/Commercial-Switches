using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit1 : MonoBehaviour
{
    [Header("UI")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public GameObject Step1Done;
    public GameObject Step2Done;
    public GameObject Step3Done;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Circuit1Step1.Step1Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit1Step2.Step2Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit1Step3.Step3Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }                
    }
}
