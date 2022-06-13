using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAndDestroy : MonoBehaviour
{
    public GameObject ParentPrefab;
    public bool reset;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ParentPrefab);
        reset = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(reset) {
        Destroy(this.gameObject);
        Application.LoadLevel(0);
      }  
    }

    public void destroyAndLoad(){
        reset = true;
    }
}
