using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public bool reset;
    public GameObject Tes;
    // Start is called before the first frame update
    void Start()
    {
        reset = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(reset) {
        Destroy(this.gameObject);
        Instantiate(Tes);
      }  
    }

    public void destroyAndLoad(){
        reset = true;
    }
}
