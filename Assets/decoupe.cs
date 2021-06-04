using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decoupe : MonoBehaviour
{
    // Start is called before the first frame update
    public wafferScript ws;
    public Transform waffer;
    public Transform clef;

    public Transform thisTransform;

    public Rigidbody wafferBody;

    public UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable grabWaffer;
    public AudioSource au;
    public bool aWaffer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider collision){
         if(collision.tag == "waffer" && ws.aPatron){
            waffer.position = thisTransform.position + thisTransform.TransformDirection(new Vector3(5.92f, 5.7f, -19f));
            waffer.eulerAngles  = new Vector3(0,0,0);
            wafferBody.constraints = RigidbodyConstraints.FreezeAll;
            grabWaffer.enabled = false;
            aWaffer=true;
            au.Play();

         }
     }

     public void creerClef(){
         if(aWaffer){        
             waffer.position = thisTransform.position + thisTransform.TransformDirection(new Vector3(-100f, 0f,0f));
             clef.position = thisTransform.position + thisTransform.TransformDirection(new Vector3 (5.92f, 7f, 26f));
     }}
}
