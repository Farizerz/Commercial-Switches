using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit7 : MonoBehaviour
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

    public GameObject[] CircuitImage;
    public TextMeshProUGUI CircuitInstructions;          

    [Header("Power Supply")]
    public GameObject PowerSupplySwitch;
    public GameObject PSIndicator;
    public GameObject PortMerahPS;
    public GameObject PortBiruPS;
    TextMeshPro PortMerahPSText;
    TextMeshPro PortBiruPSText;
    public bool isPowerSupplyOn;

    [Header("PB")]
    //public GameObject //PBSwitch;
    //public GameObject //PBIndicatorBawah;
    //public GameObject //PBIndicatorAtas;
    public GameObject PortMerahPBKiriBawah;
    public GameObject PortMerahPBKiriAtas;
    public GameObject PortMerahPBKananBawah;
    public GameObject PortMerahPBKananAtas;
    public GameObject[] PushButtonBoard;
    public GameObject PBMerah;
    public GameObject PBHijau;
    TextMeshPro PortMerahPBKiriBawahText;
    TextMeshPro PortMerahPBKiriAtasText; 
    TextMeshPro PortMerahPBKananBawahText;
    TextMeshPro PortMerahPBKananAtasText;        
    public bool isPBOn;
    public static bool setPBON;

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

    [Header("Modifier")]
    public static bool isGreen;

    // Start is called before the first frame update
    void Start()
    {
        PortMerahPSText = PortMerahPS.GetComponent<TextMeshPro>();
        PortBiruPSText = PortBiruPS.GetComponent<TextMeshPro>();

        PortMerahPBKiriBawahText = PortMerahPBKiriBawah.GetComponent<TextMeshPro>();
        PortMerahPBKiriAtasText = PortMerahPBKiriAtas.GetComponent<TextMeshPro>();
        PortMerahPBKananBawahText = PortMerahPBKananBawah.GetComponent<TextMeshPro>();
        PortMerahPBKananAtasText = PortMerahPBKananAtas.GetComponent<TextMeshPro>();

        PortMerahLamp1Text = PortMerahLamp1.GetComponent<TextMeshPro>();
        PortBiruLamp1Text = PortBiruLamp1.GetComponent<TextMeshPro>();

        PortMerahLamp2Text = PortMerahLamp2.GetComponent<TextMeshPro>();
        PortBiruLamp2Text = PortBiruLamp2.GetComponent<TextMeshPro>();            
    }

    // Update is called once per frame
    void Update()
    {
        isPBOn = setPBON;
        if(isPBOn) {
            SwitchPBOn();
        } else {
            SwitchPBOff();
        }

        //disable buttons on circuit diagram and shows the status
        if(Circuit7Step1.Step1C7Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit7Step2.Step2C7Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit7Step3.Step3C7Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }

        if(Circuit7Step4.Step4C7Done) {
            Button4.SetActive(false);
            Step4Done.SetActive(true);
        }

        if(Circuit7Step5.Step5C7Done) {
            Button5.SetActive(false);
            Step5Done.SetActive(true);
        }

        if(Circuit7Step6.Step6C7Done) {
            Button6.SetActive(false);
            Step6Done.SetActive(true);
        }

        if(Circuit7Step1.Step1C7Done &&
           Circuit7Step2.Step2C7Done &&
           Circuit7Step3.Step3C7Done &&
           Circuit7Step4.Step4C7Done &&
           Circuit7Step5.Step5C7Done &&
           Circuit7Step6.Step6C7Done       
        ) {
            CircuitInstructions.text = "Circuit Completed!";
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

        //tombol hijau
        if(isGreen) {
            PBHijau.transform.localPosition = new Vector3(0, 0, -0.35f);
            PushButtonBoard[0].SetActive(false);
            PushButtonBoard[2].SetActive(true);
            CircuitImage[2].SetActive(true);
            CircuitImage[0].SetActive(false);
        } else {
            PBHijau.transform.localPosition = new Vector3(0, 0, 0f);
            PushButtonBoard[0].SetActive(true);
            PushButtonBoard[2].SetActive(false);
            CircuitImage[2].SetActive(false);              
        }                
    }

    public void step1() {
        if(!isPowerSupplyOn) {
            PortMerahPBKiriBawahText.text = "";
            return;
        }
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }
        PortMerahPBKiriBawahText.text = "220";
        if(isPBOn) {
            PortMerahPBKananBawahText.text = "";
            return;
        }
        PortMerahPBKananBawahText.text = "220";
        return;
    }
    public void step2() {
        if(!isPowerSupplyOn) {
            PortMerahPBKiriAtasText.text = "";
            PortMerahPBKananAtasText.text = "";
            PortMerahPBKananBawahText.text = "";
            return;
        }
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }       
        if(!Circuit7Step2.Step2C7Done) {
            return;
        }
        PortMerahPBKiriAtasText.text = "220";
        if(!isPBOn){
            PortMerahPBKananAtasText.text = "";
            return;
        }       
        PortMerahPBKananAtasText.text = "220";
        return;
    }
    public void step3() {
        if(!isPowerSupplyOn) {
            PortMerahLamp1Text.text = "";
            return;
        }
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }        
        if(!Circuit7Step2.Step2C7Done) {
            return;
        }
        if(!Circuit7Step3.Step3C7Done) {
            return;
        }
        if(!isPBOn) {
           PortMerahLamp1Text.text = "";
           return; 
        }
        PortMerahLamp1Text.text = "220";        
        return; 
    }

    public void step4() {
        if(!isPowerSupplyOn) {
            PortBiruLamp2Text.text = "";
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);             
            return;
        }
        if(!Circuit7Step6.Step6C7Done) {
            return;
        }         
        if(!Circuit7Step4.Step4C7Done) {
            return;
        }
        PortBiruLamp1Text.text = "0";        
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }        
        if(!Circuit7Step2.Step2C7Done) {
            return;
        }
        if(!Circuit7Step3.Step3C7Done) {
            return;
        }
        if(!isPBOn) {
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);  
            return;          
        }         
        Lamp1OFF.SetActive(false);
        Lamp1ON.SetActive(true);         
        return;                         
    }

    public void step5() {
        if(!isPowerSupplyOn) {
            PortMerahLamp2Text.text = "";
            return;
        }
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }
        if(!Circuit7Step5.Step5C7Done) {
            return;
        }          
        if(!isPBOn) {
            PortMerahLamp2Text.text = "220";
            return;
        }
        PortMerahLamp2Text.text = "";              
        return;    
    }

    public void step6() {
        if(!isPowerSupplyOn) {
            PortBiruLamp1Text.text = "";
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);
            return;
        }
        if(!Circuit7Step6.Step6C7Done) {
            return;
        } 
        PortBiruLamp2Text.text = "0";        
        if(!Circuit7Step1.Step1C7Done) {
            return;
        }                       
        if(!Circuit7Step5.Step5C7Done) {
            return;
        }              
        if(!isPBOn) {
            Lamp2OFF.SetActive(false);
            Lamp2ON.SetActive(true);            
            return;
        }          
        Lamp2OFF.SetActive(true);
        Lamp2ON.SetActive(false);
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

    public void SwitchPBOn() {
        isPBOn = true;
        //PBSwitch.transform.Rotate(0, -50, 0);
        //PBIndicatorAtas.transform.Rotate(0, 0, 20);
        //PBIndicatorBawah.transform.Rotate(0, 0, 20);
        PBMerah.transform.localPosition = new Vector3(0, 0, -0.35f);
        PushButtonBoard[0].SetActive(false);
        PushButtonBoard[1].SetActive(true);
        CircuitImage[1].SetActive(true);
        CircuitImage[0].SetActive(false);
        CircuitImage[2].SetActive(false); 
    }

    public void SwitchPBOff() {
        isPBOn = false;
        //PBSwitch.transform.Rotate(0, 50, 0);
        //PBIndicatorAtas.transform.Rotate(0, 0, -20);
        //PBIndicatorBawah.transform.Rotate(0, 0, -20);
        PBMerah.transform.localPosition = new Vector3(0, 0, 0);
        PortMerahPBKiriBawahText.text = "";
        PortMerahPBKananBawahText.text = "";
        PortMerahPBKiriAtasText.text = "";
        PortMerahPBKananAtasText.text = "";
        PushButtonBoard[0].SetActive(true);
        PushButtonBoard[1].SetActive(false);
        PushButtonBoard[2].SetActive(false);
        CircuitImage[0].SetActive(true);
        CircuitImage[1].SetActive(false);
        CircuitImage[2].SetActive(false);                       
    }

    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1C7.isDragging = true;
        Port2Step1C7.isDragging = true;
        Port1Step2C7.isDragging = true;
        Port2Step2C7.isDragging = true;
        Port1Step3C7.isDragging = true;
        Port2Step3C7.isDragging = true;
        Port1Step4C7.isDragging = true;
        Port2Step4C7.isDragging = true;
        Port1Step5C7.isDragging = true;
        Port2Step5C7.isDragging = true;
        Port1Step6C7.isDragging = true;
        Port2Step6C7.isDragging = true;                 
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1C7.isDragging = false;
        Port2Step1C7.isDragging = false;
        Port1Step2C7.isDragging = false;
        Port2Step2C7.isDragging = false;
        Port1Step3C7.isDragging = false;
        Port2Step3C7.isDragging = false;
        Port1Step4C7.isDragging = false;
        Port2Step4C7.isDragging = false;
        Port1Step5C7.isDragging = false;
        Port2Step5C7.isDragging = false;
        Port1Step6C7.isDragging = false;
        Port2Step6C7.isDragging = false;             
    }       
}
