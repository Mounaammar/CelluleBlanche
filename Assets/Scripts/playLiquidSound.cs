using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLiquidSound : MonoBehaviour
{
    
    public AudioSource sonLiquide;
    public double degDInclinaison;
    private GameObject tournette;// = 
    
    

    void Update()
    {
        tournette = GameObject.Find("Tournette").transform.Find("tournette_plateau 1").transform.Find("porte").gameObject;
        if(tournette){
        
        if(gameObject.transform.rotation.eulerAngles.x >= degDInclinaison){
            if(!sonLiquide.isPlaying){
            sonLiquide.Play();
            if(tournette.GetComponent<estOuverte>().est == true){

            }
            
            }
        }
        }
    }
}
