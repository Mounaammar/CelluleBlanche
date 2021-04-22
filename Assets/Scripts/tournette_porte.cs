using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tournette_porte : MonoBehaviour
{


    public GameObject porte; 
    public bool estOuverte = false;



    public void OnSelectEnter(){
            if(!estOuverte){
                porte.transform.Translate(0,1f,1f, Space.Self); 
                porte.transform.Rotate(-90,0,0);
               
                estOuverte = true;  
                  
                    
           }else{
               porte.transform.Translate(0,1f,-1f, Space.Self);
               porte.transform.Rotate(90,0,0);
               estOuverte = false;
     
                
           }
    }

        public void PlayHoverEnterSound(){

        }
        
    
}
