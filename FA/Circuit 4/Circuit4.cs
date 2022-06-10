using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Circuit4 : MonoBehaviour
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
    public GameObject PortHitamPS;
    TextMeshPro PortMerahPSText;
    TextMeshPro PortHitamPSText;
    public bool isPowerSupplyOn;

    [Header("DPDT")]
    public GameObject DPDTSwitch;
    public GameObject DPDTIndicatorBawah;
    public GameObject DPDTIndicatorAtas;
    public GameObject PortMerahDPDTKiriD;
    public GameObject PortHitamDPDTKiriC;
    public GameObject PortHitamDPDTKananA;
    public GameObject PortMerahDPDTKananE;
    public GameObject PortMerahDPDTKananB;
    public GameObject PortMerahDPDTKananF;
    TextMeshPro PortMerahDPDTKiriDText;
    TextMeshPro PortHitamDPDTKiriCText; 
    TextMeshPro PortHitamDPDTKananAText;
    TextMeshPro PortMerahDPDTKananEText;
    TextMeshPro PortMerahDPDTKananBText;
    TextMeshPro PortMerahDPDTKananFText;
    public bool isDPDTOn;

    [Header("DC Motor")]
    public GameObject DCMotorDepan;
    public GameObject DCMotorBelakang;
    public GameObject DCMotorShaft;
    public GameObject PortMerahDC;
    public GameObject PortHitamDC;
    TextMeshPro PortMerahDCText;
    TextMeshPro PortHitamDCText;

    [Header("Modifier")]
    public float rotateSpeed;
    public string rotation;
    public bool startRotating;


    // Start is called before the first frame update
    void Start()
    {
        //DCMotorDepan.transform.Rotate(180, 0, 0);
        //DCMotorBelakang.transform.Rotate(180, 0, 0);
        //DCMotorShaft.transform.Rotate(180, 0, 0);

        PortMerahPSText = PortMerahPS.GetComponent<TextMeshPro>();
        PortHitamPSText = PortHitamPS.GetComponent<TextMeshPro>();

        PortMerahDPDTKiriDText = PortMerahDPDTKiriD.GetComponent<TextMeshPro>();
        PortHitamDPDTKiriCText = PortHitamDPDTKiriC.GetComponent<TextMeshPro>(); 
        PortHitamDPDTKananAText = PortHitamDPDTKananA.GetComponent<TextMeshPro>();
        PortMerahDPDTKananEText = PortMerahDPDTKananE.GetComponent<TextMeshPro>();
        PortMerahDPDTKananBText = PortMerahDPDTKananB.GetComponent<TextMeshPro>();
        PortMerahDPDTKananFText = PortMerahDPDTKananF.GetComponent<TextMeshPro>();

        PortMerahDCText = PortMerahDC.GetComponent<TextMeshPro>();
        PortHitamDCText = PortHitamDC.GetComponent<TextMeshPro>();


    }

    // Update is called once per frame
    void Update()
    {
        //mulai rotasi
        if(startRotating) {
                DCMotorDepan.transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
                DCMotorBelakang.transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
                DCMotorShaft.transform.Rotate(0, -(rotateSpeed * Time.deltaTime), 0); 
        } else {
            DCMotorDepan.transform.Rotate(0, 0, 0);
            DCMotorBelakang.transform.Rotate(0, 0, 0);
            DCMotorShaft.transform.Rotate(0, 0, 0);            
        }
        //DCMotorDepan.transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
        //DCMotorBelakang.transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
        //DCMotorShaft.transform.Rotate(0, -(rotateSpeed * Time.deltaTime), 0);

        //disable buttons on circuit diagram and shows the status
        if(Circuit4Step1.Step1C4Done) {
            Button1.SetActive(false);
            Step1Done.SetActive(true);
        }

        if(Circuit4Step2.Step2C4Done) {
            Button2.SetActive(false);
            Step2Done.SetActive(true);
        }

        if(Circuit4Step3.Step3C4Done) {
            Button3.SetActive(false);
            Step3Done.SetActive(true);
        }

        if(Circuit4Step4.Step4C4Done) {
            Button4.SetActive(false);
            Step4Done.SetActive(true);
        }

        if(Circuit4Step5.Step5C4Done) {
            Button5.SetActive(false);
            Step5Done.SetActive(true);
        }

        if(Circuit4Step6.Step6C4Done) {
            Button6.SetActive(false);
            Step6Done.SetActive(true);
        }

        step1();
        step2();
        step3();
        step4();
        step5();
        step6();
  
    }

    public void step1() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step1.Step1C4Done) {
            PortMerahDPDTKiriDText.text = "";
            return;
        }
        PortMerahDPDTKiriDText.text = "12";
        if(!isDPDTOn) {
            PortMerahDPDTKananBText.text = "12";
            PortMerahDPDTKananFText.text = "";
            return;
        }
        PortMerahDPDTKananFText.text = "12";
        PortMerahDPDTKananBText.text = "";
        return;
    }

    public void step2() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step1.Step1C4Done) {
            return;
        }
        if(!Circuit4Step2.Step2C4Done) {
            return;
        }
        PortMerahDPDTKananEText.text = "12";
        if(!Circuit4Step6.Step6C4Done) {
            return;
        }
        if(!isDPDTOn) {
            return;
        }
        PortMerahDPDTKananEText.text = "0";
        PortMerahDPDTKananBText.text = "0";
        return;
    }

    public void step3() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step1.Step1C4Done) {
            return;
        }
        if(!Circuit4Step3.Step3C4Done) {
            return;
        }
        if(!isDPDTOn) {
            PortMerahDCText.text = "12";
            return;
        }
        PortMerahDCText.text = "";                
        if(!Circuit4Step6.Step6C4Done) {
            return;
        }        
        PortMerahDCText.text = "0";
        return;                        
    }

    public void step4() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step4.Step4C4Done) {
            return;
        }
        if(!Circuit4Step6.Step6C4Done) {
            return;
        }
        PortHitamDCText.text = "0";
        if(!Circuit4Step1.Step1C4Done) {
            return;
        }      
        if(!Circuit4Step3.Step3C4Done) {
            return;
        }
        if(!isDPDTOn) {
            startRotating = true;
            return;
        }
        startRotating = false;               
        if(!Circuit4Step5.Step5C4Done) {
            return;
        }
        PortHitamDCText.text = "12";
        return;
    }

    public void step5() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step5.Step5C4Done) {
            return;
        }
        if(!isDPDTOn) {
            PortHitamDPDTKananAText.text = "0";
            PortMerahDPDTKananFText.text = "0";
            return;
        }        
        if(!Circuit4Step6.Step6C4Done) {
            return;
        } 
        PortHitamDPDTKananAText.text = "12";
        PortMerahDPDTKananFText.text = "12";
        return;                                
    }

    public void step6() {
        if(!isPowerSupplyOn) {
            startRotating = false;
            return;
        }
        if(!Circuit4Step6.Step6C4Done) {
            return;
        }
        PortHitamDPDTKiriCText.text = "0";
        if(!Circuit4Step1.Step1C4Done) {
            return;
        }
        if(!Circuit4Step2.Step2C4Done) {
            return;
        }
        if(!Circuit4Step3.Step3C4Done) {
            return;
        }
        if(!Circuit4Step4.Step4C4Done) {
            return;
        }
        if(!Circuit4Step5.Step5C4Done) {
            return;
        }
        if(!isDPDTOn) {
            PortHitamDPDTKiriCText.text = "0";
            PortMerahDCText.text = "12";
            return;
        }
        PortHitamDPDTKiriCText.text = "0";
        PortMerahDCText.text = "0";
        startRotating = true; 
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
        PortMerahDPDTKiriDText.text = "";
        PortHitamDPDTKiriCText.text = ""; 
        PortHitamDPDTKananAText.text = "";
        PortMerahDPDTKananEText.text = "";
        PortMerahDPDTKananBText.text = "";
        PortMerahDPDTKananFText.text = "";
        PortMerahDCText.text = "";
        PortHitamDCText.text = "";
        rotation = "off";                 
    }

    public void SwitchDPDTOn() {
        isDPDTOn = true;
        DPDTSwitch.transform.Rotate(0, 50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, -60, 0);
        DPDTIndicatorBawah.transform.Rotate(0, -60, 0);
        rotation = "CounterClockwise";

        if(Circuit4Step1.Step1C4Done && 
            Circuit4Step2.Step2C4Done &&
            Circuit4Step3.Step3C4Done &&
            Circuit4Step4.Step4C4Done &&
            Circuit4Step5.Step5C4Done &&
            Circuit4Step6.Step6C4Done
        ) {
            DCMotorDepan.transform.Rotate(180, 0, 0);
            DCMotorBelakang.transform.Rotate(180, 0, 0);
            DCMotorShaft.transform.Rotate(180, 0, 0); 
        }


       
    }

    public void SwitchDPDTOff() {
        isDPDTOn = false;
        DPDTSwitch.transform.Rotate(0, -50, 0);
        DPDTIndicatorAtas.transform.Rotate(0, 60, 0);
        DPDTIndicatorBawah.transform.Rotate(0, 60, 0);   
        rotation = "Clockwise";

        if(Circuit4Step1.Step1C4Done && 
            Circuit4Step2.Step2C4Done &&
            Circuit4Step3.Step3C4Done &&
            Circuit4Step4.Step4C4Done &&
            Circuit4Step5.Step5C4Done &&
            Circuit4Step6.Step6C4Done
        ) {
            DCMotorDepan.transform.Rotate(180, 0, 0);
            DCMotorBelakang.transform.Rotate(180, 0, 0);
            DCMotorShaft.transform.Rotate(180, 0, 0); 
        }     
    }
    
    //this function will be activated in Draggable.cs
    public static void enableDragging() {
        Port1Step1C4.isDragging = true;
        Port2Step1C4.isDragging = true;
        Port1Step2C4.isDragging = true;
        Port2Step2C4.isDragging = true;
        Port1Step3C4.isDragging = true;
        Port2Step3C4.isDragging = true;
        Port1Step4C4.isDragging = true;
        Port2Step4C4.isDragging = true;
        Port1Step5C4.isDragging = true;
        Port2Step5C4.isDragging = true;
        Port1Step6C4.isDragging = true;
        Port2Step6C4.isDragging = true;                 
    }

    //this function will be activated in Draggable.cs
    public static void disableDragging() {
        Port1Step1C4.isDragging = false;
        Port2Step1C4.isDragging = false;
        Port1Step2C4.isDragging = false;
        Port2Step2C4.isDragging = false;
        Port1Step3C4.isDragging = false;
        Port2Step3C4.isDragging = false;
        Port1Step4C4.isDragging = false;
        Port2Step4C4.isDragging = false;
        Port1Step5C4.isDragging = false;
        Port2Step5C4.isDragging = false;
        Port1Step6C4.isDragging = false;
        Port2Step6C4.isDragging = false;             
    }

}
