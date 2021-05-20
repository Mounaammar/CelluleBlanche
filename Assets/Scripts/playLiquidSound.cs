using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLiquidSound : MonoBehaviour
{
    
    public AudioSource sonLiquide;
    public double degDInclinaison;
    public GameObject tournette;// = 
    
    private bool estChute;

    void Update()
    {
        //tournette = GameObject.Find("Tournette").transform.Find("tournette_plateau 1").transform.Find("porte").gameObject;
       
        
        if(gameObject.transform.rotation.eulerAngles.z >= degDInclinaison){
            estChute = true;
            if(!sonLiquide.isPlaying){
            sonLiquide.Play();
            if(tournette.GetComponent<estOuverte>().est == true){

            }
            
            }
        }
        
    }

    public bool getEstChute(){
        return estChute;
    }
}
