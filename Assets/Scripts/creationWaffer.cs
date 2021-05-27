using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creationWaffer : MonoBehaviour
{
    // Start is called before the first frame update

    public Material mOriginal;  
    public Material mChangement;
    public Material mFin;
    public AudioSource au;
    private bool aWaffer;
    public GameObject waffer; 
    private bool porteEstFermee;

    public void setPorteEstFermee(bool e){
        porteEstFermee = e;
    }


    void Start()
    {
        this.GetComponent<Renderer>().material = mOriginal;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.tag == "waffer"){
            this.GetComponent<Renderer>().material = mChangement;
            aWaffer = true ;
        }
        if(collision.tag == "flacon" && aWaffer && !porteEstFermee ){

            this.GetComponent<Renderer>().material = mFin;
            au.Play();

        }


    }
}
