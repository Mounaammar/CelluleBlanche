using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creationWaffer : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource au;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.tag == "waffer"){
            au.Play();
            
        }
    }
}
