using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creationWaffer : MonoBehaviour
{
    // Start is called before the first frame update

    public Material mOriginal;  
    public Material mChangement;
    public Material mFin;

    public wafferScript wS;

    public Material mWafferFin;

    public AudioSource auLiquide;
    public AudioSource au2;
    public AudioSource auPorte;
    private bool aWaffer;
    public Transform tailleDuWaffer; 
    private bool porteEstFermee;
    private bool aLiquide;
    public Material matFin;
    public Renderer matDuWaffer;

    public bool estFait;

    public void setPorteEstFermee(bool e){
        porteEstFermee = e;
        auPorte.Play();

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
        if(collision.tag == "waffer" ){
            this.GetComponent<Renderer>().material = mChangement;
            aWaffer = true ;
        }
        if(collision.tag == "flacon" && aWaffer ){

            this.GetComponent<Renderer>().material = mFin;
            aLiquide = true;
            auLiquide.Play();
        }

        


    }
    public void lancerMachine(){

            if(aLiquide && aWaffer){
                if(!estFait){
                au2.Play();
                tailleDuWaffer.localScale += new Vector3(0f,0.1f,0f);
                matDuWaffer.material = matFin;
                wS.setEstFini();
                estFait = true;
            }

        }
    }
}
