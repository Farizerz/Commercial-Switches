﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit6Buttons : MonoBehaviour
{
    [Header("Steps Object")]
    public GameObject Step1Object;
    public GameObject Step2Object;
    public GameObject Step3Object;
    public GameObject Step4Object;
    public GameObject Step5Object;
    public GameObject Step6Object;
    public GameObject Step7Object;
    public GameObject Step8Object;
    public GameObject Step9Object;
    public GameObject Step10Object;        

    [Header("Steps Text")]
    public GameObject Step1Text;
    public GameObject Step2Text;
    public GameObject Step3Text;
    public GameObject Step4Text;
    public GameObject Step5Text;
    public GameObject Step6Text;    
    public GameObject Step7Text;
    public GameObject Step8Text;
    public GameObject Step9Text;
    public GameObject Step10Text; 

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
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }                        

        Step1Text.SetActive(true);
        Step2Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);        

    }

    public void step2() {
        Step2Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }

        Step2Text.SetActive(true);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);       
    }

    public void step3() {
        Step3Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }

        Step3Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);     
    }

    public void step4() {
        Step4Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }

        Step4Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step3Text.SetActive(false);
        Step5Text.SetActive(false);
        Step6Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);         
    }

    public void step5() {
        Step5Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }

        Step5Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step3Text.SetActive(false);
        Step6Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);  
    }
    
    public void step6() {
        Step6Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }

        Step6Text.SetActive(true);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);
        Step7Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);         
    }

    public void step7() {
        Step7Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }
        

        Step7Text.SetActive(true);
        Step6Text.SetActive(false);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);
        Step8Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);          
    }

    public void step8() {
        Step8Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }        

        Step8Text.SetActive(true);
        Step7Text.SetActive(false);
        Step6Text.SetActive(false);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);
        Step9Text.SetActive(false);
        Step10Text.SetActive(false);         
    } 

    public void step9() {
        Step9Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step10.Step10C6Done) {
            Step10Object.SetActive(false);
        }  

        Step9Text.SetActive(true);
        Step8Text.SetActive(false);
        Step7Text.SetActive(false);
        Step6Text.SetActive(false);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);
        Step6Text.SetActive(false);
        Step10Text.SetActive(false);          
    }

    public void step10() {
        Step10Object.SetActive(true);
        if(!Circuit6Step1.Step1C6Done) {
            Step1Object.SetActive(false);
        }
        if(!Circuit6Step2.Step2C6Done) {
            Step2Object.SetActive(false);
        }     
        if(!Circuit6Step4.Step4C6Done) {
            Step4Object.SetActive(false);
        }
        if(!Circuit6Step5.Step5C6Done) {
            Step5Object.SetActive(false);
        }
        if(!Circuit6Step3.Step3C6Done) {
            Step3Object.SetActive(false);
        }
        if(!Circuit6Step6.Step6C6Done) {
            Step6Object.SetActive(false);
        }
        if(!Circuit6Step7.Step7C6Done) {
            Step7Object.SetActive(false);
        }
        if(!Circuit6Step8.Step8C6Done) {
            Step8Object.SetActive(false);
        }
        if(!Circuit6Step9.Step9C6Done) {
            Step9Object.SetActive(false);
        }

        Step10Text.SetActive(true);
        Step9Text.SetActive(false);
        Step8Text.SetActive(false);
        Step7Text.SetActive(false);
        Step6Text.SetActive(false);
        Step2Text.SetActive(false);
        Step1Text.SetActive(false);
        Step4Text.SetActive(false);
        Step5Text.SetActive(false);
        Step3Text.SetActive(false);        
    }                                 
}
