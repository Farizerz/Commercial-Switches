using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit1 : MonoBehaviour
{
    [Header("UI")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    public GameObject Step1Done;
    public GameObject Step2Done;
    public GameObject Step3Done;

    public GameObject[] CircuitImage;
    public TextMeshProUGUI CircuitInstructions;

    [Header("Power Supply")]
    public GameObject PowerSupplySwitch;
    public GameObject PSIndicator;
    public GameObject PortMerah1;
    public GameObject PortBiru1;
    TextMeshPro PortMerah1Text;
    TextMeshPro PortBiru1Text;
    public bool isPowerSupplyOn;

    [Header("SPDT")]
    public GameObject SPDTSwitch;
    public GameObject SPDTIndicator;
    public GameObject PortMerah21;
    public GameObject PortMerah22;
    TextMeshPro PortMerah21Text;
    TextMeshPro PortMerah22Text;    
    public bool isSPDTOn;

    [Header("Lamp")]
    public GameObject LampOFF;
    public GameObject LampON;
    public GameObject PortMerah3;
    public GameObject PortBiru3;
    TextMeshPro PortMerah3Text;
    TextMeshPro PortBiru3Text;

    [Header("Modifier")]
    public bool init;


    // Start is called before the first frame update
    void Start()
    {
        PortMerah1Text = PortMerah1.GetComponent<TextMeshPro>();
        PortBiru1Text = PortBiru1.GetComponent<TextMeshPro>();

        PortMerah21Text = PortMerah21.GetComponent<TextMeshPro>();
        PortMerah22Text = PortMerah22.GetComponent<TextMeshPro>();

        PortMerah3Text = PortMerah3.GetComponent<TextMeshPro>();
        PortBiru3Text = PortBiru3.GetComponent<TextMeshPro>();
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

            if(Circuit1Step1.Step1Done &&
            Circuit1Step2.Step2Done &&
            Circuit1Step3.Step3Done        
            ) {
                CircuitInstructions.text = "Circuit Completed!";
            }

        
        //fungsi guard clause, sama saja dengan if else dibawah, silahkan pilih yang mana yg mudah dibaca
        step1();
        step2();
        step3();
        
/*
        //if else, silahkan comment jika ingin ganti ke guard clause.
        //if power supply on and finished step 1
        if(Circuit1Step1.Step1Done && isPowerSupplyOn) {
            PortMerah21Text.text = "220";
        } else {
            PortMerah21Text.text = "";
            PortMerah22Text.text = "";
            LampON.SetActive(false);
        }

        //if all switched on and finished step 1 & 2
        if(Circuit1Step1.Step1Done && Circuit1Step2.Step2Done && isPowerSupplyOn && isSPDTOn) { 
            PortMerah3Text.text = "220";
        } //if all switched on and finished step 1 only
        else if(Circuit1Step1.Step1Done && isPowerSupplyOn && isSPDTOn) {
            PortMerah22Text.text = "220";
        }
        else {
            PortMerah3Text.text = "";
            LampON.SetActive(false);
        }

        //if all switched on and finished step 1, 2, and 3
        if(Circuit1Step1.Step1Done && Circuit1Step2.Step2Done && Circuit1Step3.Step3Done && isPowerSupplyOn && isSPDTOn) {
            LampON.SetActive(true);
        } //if power supply switched on and finished step 3 only
        else if (Circuit1Step3.Step3Done && isPowerSupplyOn) {
            PortBiru3Text.text = "0";
        } else {
            PortBiru3Text.text = "";
            LampON.SetActive(false);
        }
*/
    }

    //start fungsi guard clause
    public void step1() {
        if(!isPowerSupplyOn) {
            PortMerah21Text.text = "";
            return;
        }
        if(!Circuit1Step1.Step1Done) {
            return;
        }
        PortMerah21Text.text = "220";
        return;
    }

    public void step2() {
        if(!isPowerSupplyOn) {
            PortMerah22Text.text = ""; 
            PortMerah3Text.text = "";
            return;
        }
        if(!Circuit1Step1.Step1Done){
            return;
        }
        if(!isSPDTOn){
            PortMerah22Text.text = "";
            PortMerah3Text.text = ""; 
            return;
        }
        PortMerah22Text.text = "220";        
        if(!Circuit1Step2.Step2Done) {
            return;
        }
        PortMerah3Text.text = "220";
        return;
    }

    public void step3() {
        if(!isPowerSupplyOn) {
            PortBiru3Text.text = "";
            LampON.SetActive(false);
            return;
        }
        if(!Circuit1Step3.Step3Done) {
            return;
        }
        PortBiru3Text.text = "0";        
        if(!Circuit1Step2.Step2Done) {
            return;
        }        
        if(!isSPDTOn){
            LampON.SetActive(false);
            return;
        }
        LampON.SetActive(true);
        return;
    }

    public void SwitchPowerSupplyOn() {
        isPowerSupplyOn = true;
        PowerSupplySwitch.transform.Rotate(0, 50, 0);
        PSIndicator.SetActive(true);
        PortMerah1Text.text = "220";
    }

    public void SwitchPowerSupplyOff() {
        isPowerSupplyOn = false;
        PowerSupplySwitch.transform.Rotate(0, -50, 0);
        PSIndicator.SetActive(false);
        PortMerah1Text.text = "0";
    }

    public void SwitchSPSTOn() {
        isSPDTOn = true;
        SPDTSwitch.transform.Rotate(0, -50, 0);
        SPDTIndicator.transform.Rotate(0, 0, 20);
        CircuitImage[0].SetActive(false);
        CircuitImage[1].SetActive(true);
    }

    public void SwitchSPSTOff() {
        isSPDTOn = false;
        SPDTSwitch.transform.Rotate(0, 50, 0);
        SPDTIndicator.transform.Rotate(0, 0, -20);
        PortMerah21Text.text = "";
        PortMerah22Text.text = "";
        CircuitImage[0].SetActive(true);
        CircuitImage[1].SetActive(false);        
    }

    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1.isDragging = true;
        Port2Step1.isDragging = true;
        Port1Step2.isDragging = true;
        Port2Step2.isDragging = true;
        Port1Step3.isDragging = true;
        Port2Step3.isDragging = true;        
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1.isDragging = false;
        Port2Step1.isDragging = false;
        Port1Step2.isDragging = false;
        Port2Step2.isDragging = false;
        Port1Step3.isDragging = false;
        Port2Step3.isDragging = false;      
    }    

}
