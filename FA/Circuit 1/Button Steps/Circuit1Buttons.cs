using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit1Buttons : MonoBehaviour
{
    [Header("Steps Object")]
    public GameObject Step1Object;
    public GameObject Step2Object;
    public GameObject Step3Object;

    [Header("Steps Text")]
    public GameObject Step1Text;
    public GameObject Step2Text;
    public GameObject Step3Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void step1() {
        Step1Object.SetActive(true);
        if(!Circuit1Step2.Step2Done) {
            Step2Object.SetActive(false);
        }
        if(!Circuit1Step3.Step3Done) {
            Step3Object.SetActive(false);
        }     

        Step1Text.SetActive(true);
        Step2Text.SetActive(false);
        Step3Text.SetActive(false);
    }

    public void step2() {
        Step2Object.SetActive(true);
        if(!Circuit1Step1.Step1Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit1Step3.Step3Done) {
            Step3Object.SetActive(false);
        }        

        Step2Text.SetActive(true);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
    }

    public void step3() {
        Step3Object.SetActive(true);
        if(!Circuit1Step1.Step1Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit1Step2.Step2Done) {
            Step2Object.SetActive(false);
        }

        Step3Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
    }       
}
