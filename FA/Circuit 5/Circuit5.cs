using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit5 : MonoBehaviour
{
    [Header("UI")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;

    public GameObject Step1Done;
    public GameObject Step2Done;
    public GameObject Step3Done;
    public GameObject Step4Done;
    public GameObject Step5Done;   

    [Header("Power Supply")]
    public GameObject PowerSupplySwitch;
    public GameObject PSIndicator;
    public GameObject PortMerahPS;
    public GameObject PortBiruPS;
    TextMeshPro PortMerahPSText;
    TextMeshPro PortBiruPSText;
    public bool isPowerSupplyOn;

    [Header("SPDT")]
    public GameObject SPDTSwitch;
    public GameObject SPDTIndicator;
    public GameObject PortMerahSPDTKiri;
    public GameObject PortMerahSPDTKananBawah;
    public GameObject PortMerahSPDTKananAtas;
    TextMeshPro PortMerahSPDTKiriText;
    TextMeshPro PortMerahSPDTKananBawahText;
    TextMeshPro PortMerahSPDTKananAtasText;        
    public bool isSPDTOn;
    public string posisiSwitch;

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

        PortMerahSPDTKiriText = PortMerahSPDTKiri.GetComponent<TextMeshPro>();
        PortMerahSPDTKananBawahText = PortMerahSPDTKananBawah.GetComponent<TextMeshPro>();
        PortMerahSPDTKananAtasText = PortMerahSPDTKananAtas.GetComponent<TextMeshPro>();

        PortMerahLamp1Text = PortMerahLamp1.GetComponent<TextMeshPro>();
        PortBiruLamp1Text = PortBiruLamp1.GetComponent<TextMeshPro>();

        PortMerahLamp2Text = PortMerahLamp2.GetComponent<TextMeshPro>();
        PortBiruLamp2Text = PortBiruLamp2.GetComponent<TextMeshPro>();            
    }

    // Update is called once per frame
    void Update()
    {
        //disable buttons on circuit diagram and shows the status
        if(Circuit5Step1.Step1C5Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit5Step2.Step2C5Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit5Step3.Step3C5Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }

        if(Circuit5Step4.Step4C5Done) {
            Button4.SetActive(false);
            Step4Done.SetActive(true);
        }

        if(Circuit5Step5.Step5C5Done) {
            Button5.SetActive(false);
            Step5Done.SetActive(true);
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
           
    }

    public void step1() {
        if(!isPowerSupplyOn) {
            PortMerahSPDTKiriText.text = "";
            PortMerahSPDTKananBawahText.text = "";
            PortMerahSPDTKananAtasText.text = "";
            return;
        }        
        if(!Circuit5Step1.Step1C5Done) {
            return;
        }
        PortMerahSPDTKiriText.text = "220";
        if(!isSPDTOn){
            PortMerahSPDTKananBawahText.text = "";
            PortMerahSPDTKananAtasText.text = "";            
            return;
        }
        if(posisiSwitch=="bawah"){
            PortMerahSPDTKananBawahText.text = "220";
            PortMerahSPDTKananAtasText.text = "";
            return;
        }
        PortMerahSPDTKananAtasText.text = "220";
        PortMerahSPDTKananBawahText.text = "";     
        return;
    }
    public void step2() {
        if(!isPowerSupplyOn) {
            PortMerahLamp2Text.text = "";
            return;
        }
        if(!Circuit5Step1.Step1C5Done) {
            return;
        }        
        if(!Circuit5Step2.Step2C5Done) {
            return;
        }
        if(!isSPDTOn) {
           PortMerahLamp2Text.text = "";
           return; 
        }
        if(posisiSwitch=="bawah") {
            return;
        }        
        PortMerahLamp2Text.text = "220";
        return;
    }

    public void step3() {
        if(!isPowerSupplyOn) {
            PortBiruLamp2Text.text = "";
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);             
            return;
        }
        if(!Circuit5Step5.Step5C5Done) {
            return;
        }
        if(!Circuit5Step3.Step3C5Done) {
            return;
        }                 
        PortBiruLamp2Text.text = "0";        
        if(!Circuit5Step1.Step1C5Done) {
            return;
        }        
        if(!Circuit5Step2.Step2C5Done) {
            return;
        }
        if(!isSPDTOn) {
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);  
            return;          
        }
        if(posisiSwitch=="bawah") { 
            return;          
        }        
        Lamp2OFF.SetActive(false);
        Lamp2ON.SetActive(true);                                 
    }

    public void step4() {
        if(!isPowerSupplyOn) {
            PortMerahLamp1Text.text = "";
            return;
        }
        if(!Circuit5Step1.Step1C5Done) {
            return;
        }
        if(!Circuit5Step4.Step4C5Done) {
            return;
        }
        if(posisiSwitch=="atas") {
            return;
        }                                  
        if(!isSPDTOn) {
            PortMerahLamp1Text.text = "";
            return;
        }        
        PortMerahLamp1Text.text = "220";             
        return;    
    }

    public void step5() {
        if(!isPowerSupplyOn) {
            PortBiruLamp1Text.text = "";
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);
            return;
        }
        if(!Circuit5Step5.Step5C5Done) {
            return;
        }     
        PortBiruLamp1Text.text = "0";        
        if(!Circuit5Step1.Step1C5Done) {
            return;
        }
        if(!Circuit5Step4.Step4C5Done) {
            return;
        }      
        if(!isSPDTOn) {
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);            
            return;
        }
        if(posisiSwitch=="atas") {       
            return;
        }                              
        Lamp1OFF.SetActive(false);
        Lamp1ON.SetActive(true);
        return;
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

    public void SwitchSPDTOnBawah() {
        isSPDTOn = true;
        posisiSwitch = "bawah";
        SPDTSwitch.transform.Rotate(0, 50, 0);
        SPDTIndicator.transform.Rotate(0, -30, 0);
    }

    public void SwitchSPDTOnAtas() {
        isSPDTOn = true;
        posisiSwitch = "atas";
        SPDTSwitch.transform.Rotate(0, -50, 0);
        SPDTIndicator.transform.Rotate(0, 30, 0);
    }           

    public void SwitchSPDTOffBawah() {
        isSPDTOn = false;
        posisiSwitch = "off";
        SPDTSwitch.transform.Rotate(0, -50, 0);
        SPDTIndicator.transform.Rotate(0, 30, 0);
        PortMerahSPDTKiriText.text = "";
        PortMerahSPDTKananBawahText.text = "";
        PortMerahSPDTKananAtasText.text = "";        
    }

    public void SwitchSPDTOffAtas() {
        isSPDTOn = false;
        posisiSwitch = "off";
        SPDTSwitch.transform.Rotate(0, 50, 0);
        SPDTIndicator.transform.Rotate(0, -30, 0);
        PortMerahSPDTKiriText.text = "";
        PortMerahSPDTKananBawahText.text = "";
        PortMerahSPDTKananAtasText.text = "";        
    }    
    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1C5.isDragging = true;
        Port2Step1C5.isDragging = true;
        Port1Step2C5.isDragging = true;
        Port2Step2C5.isDragging = true;
        Port1Step3C5.isDragging = true;
        Port2Step3C5.isDragging = true;
        Port1Step4C5.isDragging = true;
        Port2Step4C5.isDragging = true;
        Port1Step5C5.isDragging = true;
        Port2Step5C5.isDragging = true;               
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1C5.isDragging = false;
        Port2Step1C5.isDragging = false;
        Port1Step2C5.isDragging = false;
        Port2Step2C5.isDragging = false;
        Port1Step3C5.isDragging = false;
        Port2Step3C5.isDragging = false;
        Port1Step4C5.isDragging = false;
        Port2Step4C5.isDragging = false;
        Port1Step5C5.isDragging = false;
        Port2Step5C5.isDragging = false;           
    }       
}
