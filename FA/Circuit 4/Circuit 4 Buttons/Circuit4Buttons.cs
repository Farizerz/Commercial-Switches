using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit4Buttons : MonoBehaviour
{
    [Header("Steps Object")]
    public GameObject Step1Object;
    public GameObject Step2Object;
    public GameObject Step3Object;
    public GameObject Step4Object;
    public GameObject Step5Object;
    public GameObject Step6Object;    

    [Header("Steps Text")]
    public GameObject Step1Text;
    public GameObject Step2Text;
    public GameObject Step3Text;
    public GameObject Step4Text;
    public GameObject Step5Text;
    public GameObject Step6Text;    

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
        if(!Circuit4Step2.Step2C4Done) {
            Step2Object.SetActive(false);
        }
        if(!Circuit4Step3.Step3C4Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit4Step4.Step4C4Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit4Step5.Step5C4Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit4Step6.Step6C4Done) {
            Step6Object.SetActive(false);
        }

        Step1Text.SetActive(true);
        Step2Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);
    }

    public void step2() {
        Step2Object.SetActive(true);
        if(!Circuit4Step1.Step1C4Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit4Step3.Step3C4Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit4Step4.Step4C4Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit4Step5.Step5C4Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit4Step6.Step6C4Done) {
            Step6Object.SetActive(false);
        }
        Step2Text.SetActive(true);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);        
    }

    public void step3() {
        Step3Object.SetActive(true);
        if(!Circuit4Step1.Step1C4Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit4Step2.Step2C4Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit4Step4.Step4C4Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit4Step5.Step5C4Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit4Step6.Step6C4Done) {
            Step6Object.SetActive(false);
        }

        Step3Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);        
    }

    public void step4() {
        Step4Object.SetActive(true);
        if(!Circuit4Step1.Step1C4Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit4Step2.Step2C4Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit4Step3.Step3C4Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit4Step5.Step5C4Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit4Step6.Step6C4Done) {
            Step6Object.SetActive(false);
        }

        Step4Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);          
    }

    public void step5() {
        Step5Object.SetActive(true);
        if(!Circuit4Step1.Step1C4Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit4Step2.Step2C4Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit4Step4.Step4C4Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit4Step3.Step3C4Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit4Step6.Step6C4Done) {
            Step6Object.SetActive(false);
        }

        Step5Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step3Text.SetActive(false);
        Step6Text.SetActive(false);  
    }
    
    public void step6() {
        Step6Object.SetActive(true);
        if(!Circuit4Step1.Step1C4Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit4Step2.Step2C4Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit4Step4.Step4C4Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit4Step5.Step5C4Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit4Step3.Step3C4Done) {
            Step3Object.SetActive(false);
        }

        Step6Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);          
    }           
}
