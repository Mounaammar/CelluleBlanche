using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tournette_porte : MonoBehaviour
{


    public GameObject porte; 
    public GameObject fond;
    public bool estOuverte = false;
    public  creationWaffer fondScript;

    public void Update(){
      //  porte.estOuverte.est = estOuverte;
    }

    public void OnStart(){
        //fondScript = fond.GetComponent<creationWaffer>();
      
    }



    public void OnSelectEnter(){
            if(!estOuverte){
                porte.transform.Translate(0,1f,1f, Space.Self); 
                porte.transform.Rotate(-90,0,0);
                estOuverte = true;
                fondScript.setPorteEstFermee(false);  
                  
                    
           }else{
               porte.transform.Translate(0,1f,-1f, Space.Self);
               porte.transform.Rotate(90,0,0);
                estOuverte = false;
                fondScript.setPorteEstFermee(true);
                
           }
    }

        public void PlayHoverEnterSound(){

        }
        
    
}
