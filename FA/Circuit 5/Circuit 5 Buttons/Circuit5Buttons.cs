using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit5Buttons : MonoBehaviour
{
    [Header("Steps Object")]
    public GameObject Step1Object;
    public GameObject Step2Object;
    public GameObject Step3Object;
    public GameObject Step4Object;
    public GameObject Step5Object;   

    [Header("Steps Text")]
    public GameObject Step1Text;
    public GameObject Step2Text;
    public GameObject Step3Text;
    public GameObject Step4Text;
    public GameObject Step5Text;  

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
        if(!Circuit5Step2.Step2C5Done) {
            Step2Object.SetActive(false);
        }
        if(!Circuit5Step3.Step3C5Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit5Step4.Step4C5Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit5Step5.Step5C5Done) {
            Step5Object.SetActive(false);
        }

        Step1Text.SetActive(true);
        Step2Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
    }

    public void step2() {
        Step2Object.SetActive(true);
        if(!Circuit5Step1.Step1C5Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit5Step3.Step3C5Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit5Step4.Step4C5Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit5Step5.Step5C5Done) {
            Step5Object.SetActive(false);
        }
        Step2Text.SetActive(true);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);     
    }

    public void step3() {
        Step3Object.SetActive(true);
        if(!Circuit5Step1.Step1C5Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit5Step2.Step2C5Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit5Step4.Step4C5Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit5Step5.Step5C5Done) {
            Step5Object.SetActive(false);
        }

        Step3Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);      
    }

    public void step4() {
        Step4Object.SetActive(true);
        if(!Circuit5Step1.Step1C5Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit5Step2.Step2C5Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit5Step3.Step3C5Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit5Step5.Step5C5Done) {
            Step5Object.SetActive(false);
        }

        Step4Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step5Text.SetActive(false);         
    }

    public void step5() {
        Step5Object.SetActive(true);
        if(!Circuit5Step1.Step1C5Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit5Step2.Step2C5Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit5Step4.Step4C5Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit5Step3.Step3C5Done) {
            Step3Object.SetActive(false);
        }

        Step5Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step3Text.SetActive(false); 
    }           
}
