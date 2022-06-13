using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit6 : MonoBehaviour
{
    [Header("UI")]
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject Button7;
    public GameObject Button8;
    public GameObject Button9;
    public GameObject Button10;

    public GameObject Step1Done;
    public GameObject Step2Done;
    public GameObject Step3Done;
    public GameObject Step4Done;
    public GameObject Step5Done;   
    public GameObject Step6Done;
    public GameObject Step7Done;
    public GameObject Step8Done;
    public GameObject Step9Done;
    public GameObject Step10Done;

    public GameObject[] CircuitImage;
    public TextMeshProUGUI CircuitInstructions;         

    [Header("Power Supply")]
    public GameObject PowerSupplySwitch;
    public GameObject PSIndicator;
    public GameObject PortMerahPS;
    public GameObject PortHitamPS;
    TextMeshPro PortMerahPSText;
    TextMeshPro PortHitamPSText;
    public bool isPowerSupplyOn;

    [Header("DPDT")]
    public GameObject DPDTSwitch;
    public GameObject DPDTIndicatorBawah;
    public GameObject DPDTIndicatorAtas;
    public GameObject PortMerahDPDTKiriD;
    public GameObject PortMerahDPDTKiriC;
    public GameObject PortMerahDPDTKananA;
    public GameObject PortMerahDPDTKananE;
    public GameObject PortMerahDPDTKananB;
    public GameObject PortMerahDPDTKananF;
    TextMeshPro PortMerahDPDTKiriDText;
    TextMeshPro PortMerahDPDTKiriCText; 
    TextMeshPro PortMerahDPDTKananAText;
    TextMeshPro PortMerahDPDTKananEText;
    TextMeshPro PortMerahDPDTKananBText;
    TextMeshPro PortMerahDPDTKananFText;
    public bool isDPDTOn;
    public string posisiSwitch;

    [Header("Pilot Light Merah")]
    public GameObject PilotLight0FFMerah;
    public GameObject PilotLight0NMerah;
    public GameObject PortMerahPLMerah;
    public GameObject PortHitamPLMerah;
    TextMeshPro PortMerahPLMerahText;
    TextMeshPro PortHitamPLMerahText;

    [Header("Pilot Light Kuning")]
    public GameObject PilotLight0FFKuning;
    public GameObject PilotLight0NKuning;
    public GameObject PortMerahPLKuning;
    public GameObject PortHitamPLKuning;
    TextMeshPro PortMerahPLKuningText;
    TextMeshPro PortHitamPLKuningText;

    [Header("Lamp 1")]
    public GameObject Lamp1OFF;
    public GameObject Lamp1ON;
    public GameObject PortMerahLamp1;
    public GameObject PortHitamLamp1;
    TextMeshPro PortMerahLamp1Text;
    TextMeshPro PortHitamLamp1Text;

    [Header("Lamp 2")]
    public GameObject Lamp2OFF;
    public GameObject Lamp2ON;
    public GameObject PortMerahLamp2;
    public GameObject PortHitamLamp2;
    TextMeshPro PortMerahLamp2Text;
    TextMeshPro PortHitamLamp2Text;

    // Start is called before the first frame update
    void Start()
    {
        PortMerahPSText = PortMerahPS.GetComponent<TextMeshPro>();
        PortHitamPSText = PortHitamPS.GetComponent<TextMeshPro>();

        PortMerahDPDTKiriDText = PortMerahDPDTKiriD.GetComponent<TextMeshPro>();
        PortMerahDPDTKiriCText = PortMerahDPDTKiriC.GetComponent<TextMeshPro>(); 
        PortMerahDPDTKananAText = PortMerahDPDTKananA.GetComponent<TextMeshPro>();
        PortMerahDPDTKananEText = PortMerahDPDTKananE.GetComponent<TextMeshPro>();
        PortMerahDPDTKananBText = PortMerahDPDTKananB.GetComponent<TextMeshPro>();
        PortMerahDPDTKananFText = PortMerahDPDTKananF.GetComponent<TextMeshPro>();

        PortMerahPLMerahText = PortMerahPLMerah.GetComponent<TextMeshPro>();
        PortHitamPLMerahText = PortHitamPLMerah.GetComponent<TextMeshPro>();

        PortMerahPLKuningText = PortMerahPLKuning.GetComponent<TextMeshPro>();
        PortHitamPLKuningText = PortHitamPLKuning.GetComponent<TextMeshPro>();

        PortMerahLamp1Text = PortMerahLamp1.GetComponent<TextMeshPro>();
        PortHitamLamp1Text = PortHitamLamp1.GetComponent<TextMeshPro>();

        PortMerahLamp2Text = PortMerahLamp2.GetComponent<TextMeshPro>();
        PortHitamLamp2Text = PortHitamLamp2.GetComponent<TextMeshPro>();            
    }

    // Update is called once per frame
    void Update()
    {
        //disable buttons on circuit diagram and shows the status
        if(Circuit6Step1.Step1C6Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit6Step2.Step2C6Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit6Step3.Step3C6Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }

        if(Circuit6Step4.Step4C6Done) {
            Button4.SetActive(false);
            Step4Done.SetActive(true);
        }

        if(Circuit6Step5.Step5C6Done) {
            Button5.SetActive(false);
            Step5Done.SetActive(true);
        }

        if(Circuit6Step6.Step6C6Done) {
            Button6.SetActive(false);
            Step6Done.SetActive(true);
        }

        if(Circuit6Step7.Step7C6Done) {
            Button7.SetActive(false);
            Step7Done.SetActive(true);
        }

        if(Circuit6Step8.Step8C6Done) {
            Button8.SetActive(false);
            Step8Done.SetActive(true);
        }

        if(Circuit6Step9.Step9C6Done) {
            Button9.SetActive(false);
            Step9Done.SetActive(true);
        }

        if(Circuit6Step10.Step10C6Done) {
            Button10.SetActive(false);
            Step10Done.SetActive(true);
        }

        if(Circuit6Step1.Step1C6Done &&
           Circuit6Step2.Step2C6Done &&
           Circuit6Step3.Step3C6Done &&
           Circuit6Step4.Step4C6Done &&
           Circuit6Step5.Step5C6Done &&
           Circuit6Step6.Step6C6Done &&
           Circuit6Step7.Step7C6Done &&
           Circuit6Step8.Step8C6Done &&
           Circuit6Step9.Step9C6Done &&
           Circuit6Step10.Step10C6Done       
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

        step6();

        step7();

        step8();

        step9();

        step10();

        //hidupkan lampu
        TurnOnLamp1();
        TurnOnLamp2();

        //hidupkan pilot lights
        TurnOnRedLight();
        TurnOnYellowLight();
           
    }

    public void step1() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        PortMerahPSText.text = "12";
        PortMerahDPDTKiriDText.text = "12";
        if(posisiSwitch=="atas") {
            PortMerahDPDTKananBText.text = "12";
            return;
        }
        if(posisiSwitch=="bawah") {
            PortMerahDPDTKananFText.text = "12";
            return;
        }
        return;
    }
    public void step2() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step2.Step2C6Done) {
            return;
        }
        PortMerahDPDTKiriCText.text = "12";
        if(posisiSwitch=="atas") {
            PortMerahDPDTKananAText.text = "12";
            return;
        }
        if(posisiSwitch=="bawah") {
            PortMerahDPDTKananEText.text = "12";
            return;
        }                        
        return;
    }

    public void step3() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step2.Step2C6Done) {
            return;
        }
        if(!Circuit6Step3.Step3C6Done) {
            return;
        }
        if(posisiSwitch=="atas") {
            PortMerahLamp1Text.text = "12";
            return;
        }
        PortMerahLamp1Text.text = "";                        
        return;         
    }

    public void step4() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step2.Step2C6Done) {
            return;
        }
        if(!Circuit6Step4.Step4C6Done) {
            return;
        }
        if(posisiSwitch=="bawah") {
            PortMerahLamp2Text.text = "12";
            return;
        }
        PortMerahLamp2Text.text = "";                           
        return;
    }

    public void step5() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(posisiSwitch!="atas") {
            PortMerahDPDTKananBText.text = "";
            PortMerahPLMerahText.text = "";
            return;
        }
        PortMerahDPDTKananBText.text = "12";        
        if(!Circuit6Step5.Step5C6Done) {
            return;
        }
        PortMerahPLMerahText.text = "12";                        
        return;
    }

    public void step6() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(posisiSwitch!="bawah") {
            PortMerahDPDTKananFText.text = "";
            PortMerahPLKuningText.text = "";
            return;
        }
        PortMerahDPDTKananFText.text = "12";        
        if(!Circuit6Step6.Step6C6Done) {
            return;
        }
        PortMerahPLKuningText.text = "12";                        
        return;
    }
    public void step7() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step7.Step7C6Done) {
            return;
        }
        if(!Circuit6Step8.Step8C6Done) {
            return;
        }        
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        PortHitamLamp1Text.text = "0";                        
        return;
    }

    public void step8() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step8.Step8C6Done) {
            return;    
        }
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        PortHitamLamp2Text.text = "0";                
       return;                       
    }

    public void step9() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        PortHitamPLKuningText.text = "0";               
        return;
    }

    public void step10() {
        if(!isPowerSupplyOn) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        PortHitamPLMerahText.text = "0";                      
        return;
    }

    public void TurnOnLamp1() {
        if(!isPowerSupplyOn) {
            Lamp1OFF.SetActive(true);
            Lamp1ON.SetActive(false);
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step2.Step2C6Done) {
            return;
        }
        if(!Circuit6Step3.Step3C6Done) {
            return;
        }
        if(!Circuit6Step7.Step7C6Done) {
            return;
        }
        if(!Circuit6Step8.Step8C6Done) {
            return;
        }        
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        if(posisiSwitch=="atas") {
            Lamp1OFF.SetActive(false);
            Lamp1ON.SetActive(true);
            return; 
        }
        Lamp1OFF.SetActive(true);
        Lamp1ON.SetActive(false);        
        return;                
    }

    public void TurnOnRedLight() {
        if(!isPowerSupplyOn) {
            PilotLight0FFMerah.SetActive(true);
            PilotLight0NMerah.SetActive(false);
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step5.Step5C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        if(posisiSwitch=="atas") {
            PilotLight0FFMerah.SetActive(false);
            PilotLight0NMerah.SetActive(true);
            return;  
        }
        PilotLight0FFMerah.SetActive(true);
        PilotLight0NMerah.SetActive(false);              
        return;
    }

    public void TurnOnLamp2() {
        if(!isPowerSupplyOn) {
            Lamp2OFF.SetActive(true);
            Lamp2ON.SetActive(false);
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step2.Step2C6Done) {
            return;
        }
        if(!Circuit6Step3.Step3C6Done) {
            return;
        }
        if(!Circuit6Step8.Step8C6Done) {
            return;
        }        
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        if(posisiSwitch=="bawah") {
            Lamp2OFF.SetActive(false);
            Lamp2ON.SetActive(true);
            return; 
        }
        Lamp2OFF.SetActive(true);
        Lamp2ON.SetActive(false);              
        return;               
    }

    public void TurnOnYellowLight() {
        if(!isPowerSupplyOn) {
            PilotLight0FFKuning.SetActive(true);
            PilotLight0NKuning.SetActive(false);
            return;
        }
        if(!Circuit6Step1.Step1C6Done) {
            return;
        }
        if(!Circuit6Step6.Step6C6Done) {
            return;
        }
        if(!Circuit6Step9.Step9C6Done) {
            return;
        }        
        if(!Circuit6Step10.Step10C6Done) {
            return;
        }
        if(posisiSwitch=="bawah") {
            PilotLight0FFKuning.SetActive(false);
            PilotLight0NKuning.SetActive(true);
            return;
        }
        PilotLight0FFKuning.SetActive(true);
        PilotLight0NKuning.SetActive(false);                
        return;
    }    

    public void SwitchPowerSupplyOn() {
        isPowerSupplyOn = true;
        PowerSupplySwitch.transform.Rotate(0, 50, 0);
        PSIndicator.SetActive(true);
        PortMerahPSText.text = "12";
        PortHitamPSText.text = "0";

    }

    public void SwitchPowerSupplyOff() {
        isPowerSupplyOn = false;
        PowerSupplySwitch.transform.Rotate(0, -50, 0);
        PSIndicator.SetActive(false);
        PortMerahPSText.text = "";
        PortHitamPSText.text = "";
        PortMerahDPDTKiriCText.text = "";
        PortMerahDPDTKiriDText.text = "";
        PortMerahDPDTKananAText.text = "";
        PortMerahDPDTKananEText.text = "";
        PortMerahDPDTKananBText.text = "";
        PortMerahDPDTKananFText.text = "";
        PortMerahPLMerahText.text = "";
        PortHitamPLMerahText.text = "";
        PortMerahPLKuningText.text = "";
        PortHitamPLKuningText.text = "";
        PortMerahLamp1Text.text = "";
        PortHitamLamp1Text.text = "";
        PortMerahLamp2Text.text = "";
        PortHitamLamp2Text.text = "";
    }

    public void SwitchDPDTOnBawah() {
        isDPDTOn = true;
        posisiSwitch = "bawah";
        DPDTSwitch.transform.Rotate(0, 50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, -30, 0);
        DPDTIndicatorBawah.transform.Rotate(0, -30, 0);
        CircuitImage[0].SetActive(false);
        CircuitImage[1].SetActive(false); 
        CircuitImage[2].SetActive(true);        
    }

    public void SwitchDPDTOnAtas() {
        isDPDTOn = true;
        posisiSwitch = "atas";
        DPDTSwitch.transform.Rotate(0, -50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, 30, 0);
        DPDTIndicatorBawah.transform.Rotate(0, 30, 0);
        CircuitImage[0].SetActive(false);
        CircuitImage[1].SetActive(true); 
        CircuitImage[2].SetActive(false);        
    }           

    public void SwitchDPDTOffBawah() {
        isDPDTOn = false;
        posisiSwitch = "off";
        DPDTSwitch.transform.Rotate(0, -50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, 30, 0); 
        DPDTIndicatorBawah.transform.Rotate(0, 30, 0); 
        PortMerahDPDTKiriCText.text = "";
        PortMerahDPDTKiriDText.text = "";
        PortMerahDPDTKananAText.text = "";
        PortMerahDPDTKananEText.text = "";
        PortMerahDPDTKananBText.text = "";
        PortMerahDPDTKananFText.text = ""; 
        PortMerahPLMerahText.text = "";
        PortMerahPLKuningText.text = "";
        CircuitImage[0].SetActive(true);
        CircuitImage[2].SetActive(false); 
        CircuitImage[1].SetActive(false);                     
    }


    public void SwitchDPDTOffAtas() {
        isDPDTOn = false;
        posisiSwitch = "off";
        DPDTSwitch.transform.Rotate(0, 50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, -30, 0);
        DPDTIndicatorBawah.transform.Rotate(0, -30, 0);
        PortMerahDPDTKiriCText.text = "";
        PortMerahDPDTKiriDText.text = "";
        PortMerahDPDTKananAText.text = "";
        PortMerahDPDTKananEText.text = "";
        PortMerahDPDTKananBText.text = "";
        PortMerahDPDTKananFText.text = "";
        PortMerahPLMerahText.text = "";
        PortMerahPLKuningText.text = "";
        CircuitImage[0].SetActive(true);
        CircuitImage[2].SetActive(false); 
        CircuitImage[1].SetActive(false);            
    }     

    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1C6.isDragging = true;
        Port2Step1C6.isDragging = true;
        Port1Step2C6.isDragging = true;
        Port2Step2C6.isDragging = true;
        Port1Step3C6.isDragging = true;
        Port2Step3C6.isDragging = true;
        Port1Step4C6.isDragging = true;
        Port2Step4C6.isDragging = true;
        Port1Step5C6.isDragging = true;
        Port2Step5C6.isDragging = true;        
        Port1Step7C6.isDragging = true;
        Port2Step7C6.isDragging = true;
        Port1Step8C6.isDragging = true;
        Port2Step8C6.isDragging = true;
        Port1Step9C6.isDragging = true;
        Port2Step9C6.isDragging = true;
        Port1Step10C6.isDragging = true;
        Port2Step10C6.isDragging = true;                       
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1C6.isDragging = false;
        Port2Step1C6.isDragging = false;
        Port1Step2C6.isDragging = false;
        Port2Step2C6.isDragging = false;
        Port1Step3C6.isDragging = false;
        Port2Step3C6.isDragging = false;
        Port1Step4C6.isDragging = false;
        Port2Step4C6.isDragging = false;
        Port1Step5C6.isDragging = false;
        Port2Step5C6.isDragging = false;
        Port1Step7C6.isDragging = false;
        Port2Step7C6.isDragging = false;
        Port1Step8C6.isDragging = false;
        Port2Step8C6.isDragging = false;
        Port1Step9C6.isDragging = false;
        Port2Step9C6.isDragging = false;
        Port1Step10C6.isDragging = false;
        Port2Step10C6.isDragging = false;                     
    }       
}