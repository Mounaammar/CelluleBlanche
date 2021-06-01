using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LancementMachine : MonoBehaviour
{

    public GameObject tournette;
    public creationWaffer cw;
    
    // Start is called before the first frame update
    void Start()
    {
       // cw = tournette.GetComponent<creationWaffer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelectEnter(){
       cw.lancerMachine();
    }
}
