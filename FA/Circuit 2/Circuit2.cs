using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit2 : MonoBehaviour
{
    [Header("UI")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;

    public GameObject Step1Done;
    public GameObject Step2Done;
    public GameObject Step3Done;
    public GameObject Step4Done;
    public GameObject Step5Done;
    public GameObject Step6Done;    

    [Header("Power Supply")]
    public GameObject PowerSupplySwitch;
    public GameObject PSIndicator;
    public GameObject PortMerahPS;
    public GameObject PortBiruPS;
    TextMeshPro PortMerahPSText;
    TextMeshPro PortBiruPSText;
    public bool isPowerSupplyOn;

    [Header("DPST")]
    public GameObject DPSTSwitch;
    public GameObject DPSTIndicatorBawah;
    public GameObject DPSTIndicatorAtas;
    public GameObject PortMerahDPSTKiriBawah;
    public GameObject PortMerahDPSTKiriAtas;
    public GameObject PortMerahDPSTKananBawah;
    public GameObject PortMerahDPSTKananAtas;
    TextMeshPro PortMerahDPSTKiriBawahText;
    TextMeshPro PortMerahDPSTKiriAtasText; 
    TextMeshPro PortMerahDPSTKananBawahText;
    TextMeshPro PortMerahDPSTKananAtasText;        
    public bool isDPSTOn;

    [Header("Lamp 1")]
    public GameObject Lamp1OFF;
    public GameObject Lamp1ON;
    public GameObject PortMerahLamp1;
    public GameObject PortBiruLamp1;
    TextMeshPro PortMerahLamp1Text;
    TextMeshPro PortBiruLamp1Text;

    [Header("Lamp 2")]
    public GameObject Lamp2OFF;
    public GameObject Lamp2ON;
    public GameObject PortMerahLamp2;
    public GameObject PortBiruLamp2;
    TextMeshPro PortMerahLamp2Text;
    TextMeshPro PortBiruLamp2Text;

    // Start is called before the first frame update
    void Start()
    {
        PortMerahPSText = PortMerahPS.GetComponent<TextMeshPro>();
        PortBiruPSText = PortBiruPS.GetComponent<TextMeshPro>();

        PortMerahDPSTKiriBawahText = PortMerahDPSTKiriBawah.GetComponent<TextMeshPro>();
        PortMerahDPSTKiriAtasText = PortMerahDPSTKiriAtas.GetComponent<TextMeshPro>();
        PortMerahDPSTKananBawahText = PortMerahDPSTKananBawah.GetComponent<TextMeshPro>();
        PortMerahDPSTKananAtasText = PortMerahDPSTKananAtas.GetComponent<TextMeshPro>();

        PortMerahLamp1Text = PortMerahLamp1.GetComponent<TextMeshPro>();
        PortBiruLamp1Text = PortBiruLamp1.GetComponent<TextMeshPro>();

        PortMerahLamp2Text = PortMerahLamp2.GetComponent<TextMeshPro>();
        PortBiruLamp2Text = PortBiruLamp2.GetComponent<TextMeshPro>();            
    }

    // Update is called once per frame
    void Update()
    {
        //disable buttons on circuit diagram and shows the status
        if(Circuit2Step1.Step1C2Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit2Step2.Step2C2Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit2Step3.Step3C2Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }

        if(Circuit2Step4.Step4C2Done) {
            Button4.SetActive(false);
            Step4Done.SetActive(true);
        }

        if(Circuit2Step5.Step5C2Done) {
            Button5.SetActive(false);
            Step5Done.SetActive(true);
        }

        if(Circuit2Step6.Step6C2Done) {
            Button6.SetActive(false);
            Step6Done.SetActive(true);
        }
        
        //if all switched on and finished step 1
        step1();

        //if all switched on and finished step 1 & 2
        step2();

        //if all switched on and finished step 1, 2 & 3
        step3();

        //if all switched on and finished step 1, 2, 3 & 4
        step4();

        //if all switched on and finished step 1, 2, 3, 4 & 5
        step5();

        //if all switched on and finished step 1, 2, 3, 4, 5 & 6
        step6();                
    }

    public void step1() {
        if(!isPowerSupplyOn) {
            PortMerahDPSTKiriBawahText.text = "";
            return;
        }
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }
        PortMerahDPSTKiriBawahText.text = "220";
    }
    public void step2() {
        if(!isPowerSupplyOn) {
            PortMerahDPSTKiriAtasText.text = "";
            PortMerahDPSTKananAtasText.text = "";
            PortMerahDPSTKananBawahText.text = "";
            return;
        }
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }       
        if(!isDPSTOn && !Circuit2Step2.Step2C2Done) {
            PortMerahDPSTKananAtasText.text = "";
            PortMerahDPSTKananBawahText.text = "";
            return;
        }
        if(!isDPSTOn && Circuit2Step2.Step2C2Done) {
            PortMerahDPSTKiriAtasText.text = "220"; 
            return; 
        }
        if (!isDPSTOn) {
            PortMerahDPSTKananAtasText.text = "";
            PortMerahDPSTKananBawahText.text = "";
            return;
        }
        PortMerahDPSTKananBawahText.text = "220"; 
        if(!Circuit2Step2.Step2C2Done){
            return;
        }
        PortMerahDPSTKiriAtasText.text = "220";      
        PortMerahDPSTKananAtasText.text = "220";                
    }
    public void step3() {
        if(!isPowerSupplyOn) {
            PortMerahLamp2Text.text = "";
            return;
        }
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }        
        if(!Circuit2Step2.Step2C2Done) {
            return;
        }
        if(!isDPSTOn) {
           PortMerahLamp2Text.text = "";
           return; 
        }
        if(!Circuit2Step3.Step3C2Done) {
            return;
        }
        PortMerahLamp2Text.text = "220";
        return; 
    }

    public void step4() {
        if(!isPowerSupplyOn) {
            PortBiruLamp2Text.text = "";
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);             
            return;
        }
        if(!Circuit2Step6.Step6C2Done) {
            return;
        }         
        if(!Circuit2Step4.Step4C2Done) {
            return;
        }
        PortBiruLamp2Text.text = "0";        
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }        
        if(!Circuit2Step2.Step2C2Done) {
            return;
        }
        if(!Circuit2Step3.Step3C2Done) {
            return;
        }
        if(!isDPSTOn) {
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);  
            return;          
        }         
        Lamp2OFF.SetActive(false);
        Lamp2ON.SetActive(true);         
        if(!Circuit2Step5.Step5C2Done) {
            return;
        }                           
    }

    public void step5() {
        if(!isPowerSupplyOn) {
            PortMerahLamp1Text.text = "";
            return;
        }
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }
        if(!Circuit2Step5.Step5C2Done) {
            return;
        }          
        if(!isDPSTOn) {
            PortMerahLamp1Text.text = "";
            return;
        }
        PortMerahLamp1Text.text = "220";              
        return;    
    }

    public void step6() {
        if(!isPowerSupplyOn) {
            PortBiruLamp1Text.text = "";
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);
            return;
        }
        if(!Circuit2Step6.Step6C2Done) {
            return;
        } 
        PortBiruLamp1Text.text = "0";        
        if(!Circuit2Step1.Step1C2Done) {
            return;
        }                       
        if(!Circuit2Step5.Step5C2Done) {
            return;
        }              
        if(!isDPSTOn) {
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);            
            return;
        }          
        Lamp1OFF.SetActive(false);
        Lamp1ON.SetActive(true);
        if(!Circuit2Step2.Step2C2Done) {
            return;
        }
        if(Circuit2Step3.Step3C2Done) {
            return;
        }
        if(!Circuit2Step4.Step4C2Done) {
            return;
        }
    }

    public void SwitchPowerSupplyOn() {
        isPowerSupplyOn = true;
        PowerSupplySwitch.transform.Rotate(0, 50, 0);
        PSIndicator.SetActive(true);
        PortMerahPSText.text = "220";
    }

    public void SwitchPowerSupplyOff() {
        isPowerSupplyOn = false;
        PowerSupplySwitch.transform.Rotate(0, -50, 0);
        PSIndicator.SetActive(false);
        PortMerahPSText.text = "0";
    }

    public void SwitchDPSTOn() {
        isDPSTOn = true;
        DPSTSwitch.transform.Rotate(0, -50, 0);
        DPSTIndicatorAtas.transform.Rotate(0, 0, 20);
        DPSTIndicatorBawah.transform.Rotate(0, 0, 20);
    }

    public void SwitchDPSTOff() {
        isDPSTOn = false;
        DPSTSwitch.transform.Rotate(0, 50, 0);
        DPSTIndicatorAtas.transform.Rotate(0, 0, -20);
        DPSTIndicatorBawah.transform.Rotate(0, 0, -20);
        PortMerahDPSTKiriBawahText.text = "";
        PortMerahDPSTKananBawahText.text = "";
        PortMerahDPSTKiriAtasText.text = "";
        PortMerahDPSTKananAtasText.text = "";        
    }
    
    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1C2.isDragging = true;
        Port2Step1C2.isDragging = true;
        Port1Step2C2.isDragging = true;
        Port2Step2C2.isDragging = true;
        Port1Step3C2.isDragging = true;
        Port2Step3C2.isDragging = true;
        Port1Step4C2.isDragging = true;
        Port2Step4C2.isDragging = true;
        Port1Step5C2.isDragging = true;
        Port2Step5C2.isDragging = true;
        Port1Step6C2.isDragging = true;
        Port2Step6C2.isDragging = true;                 
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1C2.isDragging = false;
        Port2Step1C2.isDragging = false;
        Port1Step2C2.isDragging = false;
        Port2Step2C2.isDragging = false;
        Port1Step3C2.isDragging = false;
        Port2Step3C2.isDragging = false;
        Port1Step4C2.isDragging = false;
        Port2Step4C2.isDragging = false;
        Port1Step5C2.isDragging = false;
        Port2Step5C2.isDragging = false;
        Port1Step6C2.isDragging = false;
        Port2Step6C2.isDragging = false;             
    }       
}
