using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSimulationOptions : MonoBehaviour
{

    [Header("UI")]
    public TextMeshProUGUI animationTitle;
    public GameObject panel;
    public GameObject btnShow;
    public GameObject btnHide;
    public GameObject[] CircuitUI;


    [Header("GameObject")]
    public GameObject[] Circuit;

    [Header("Modifier")]
    public int CircuitNumber;
    bool isShow;
    float slideShow;
    public float slideSpeed;    
    
   
    // Start is called before the first frame update
    void Start()
    {
        isShow = true;
        CircuitNumber = -1;
        slideShow = 320;
        animationTitle.text = "Select Circuit";        
    }

    // Update is called once per frame
    void Update()
    {
        if(isShow){
            if(slideShow < 320) {
                slideShow+=slideSpeed;
                panel.transform.localPosition = new Vector3(slideShow, 0, 0);
            }
        } else {
            if(slideShow > 0) {
                slideShow-=slideSpeed;
                panel.transform.localPosition = new Vector3(slideShow, 0, 0);
            }            
        }

        for(int i= 0; i < Circuit.Length; i++) {
            if(i == CircuitNumber) {
                animationTitle.text = "Circuit "+(i+1);
                Circuit[i].SetActive(true);
                CircuitUI[i].SetActive(true);
            } else {
                Circuit[i].SetActive(false);
                CircuitUI[i].SetActive(false);                
            } 
        }
    }

    public void Show() {
        isShow = true;
        btnShow.SetActive(false);
        btnHide.SetActive(true);
    }
    public void Hide() {
        isShow = false;
        btnShow.SetActive(true);
        btnHide.SetActive(false);
    }


    public void satu(){
        CircuitNumber = 0;
    }
    public void dua(){
        CircuitNumber = 1;
    }
    public void tiga(){
        CircuitNumber = 2;
    }
    public void empat(){
        CircuitNumber = 3;
    }
    public void lima(){
        CircuitNumber = 4;
    }    
    public void enam(){
        CircuitNumber = 5;
        isShow = false;
        btnShow.SetActive(true);
        btnHide.SetActive(false);        
    }
    public void tujuh(){
        isShow = false;
        btnShow.SetActive(true);
        btnHide.SetActive(false);        
        CircuitNumber = 6;
    }        
}
