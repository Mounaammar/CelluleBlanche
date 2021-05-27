using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tournette_porte : MonoBehaviour
{


    public GameObject porte; 
    public GameObject fond;
    public bool estOuverte = false;
    private MonoBehaviour fondScript;

    public void Update(){
      //  porte.estOuverte.est = estOuverte;
    }

    public void OnStart(){
      
    }



    public void OnSelectEnter(){
            if(!estOuverte){
                porte.transform.Translate(0,1f,1f, Space.Self); 
                porte.transform.Rotate(-90,0,0);
                estOuverte = true;
                fond.GetComponent<creationWaffer>().setPorteEstFermee(true);  
                  
                    
           }else{
               porte.transform.Translate(0,1f,-1f, Space.Self);
               porte.transform.Rotate(90,0,0);
                estOuverte = false;
               fond.GetComponent<creationWaffer>().setPorteEstFermee(false);
     
                
           }
    }

        public void PlayHoverEnterSound(){

        }
        
    
}
