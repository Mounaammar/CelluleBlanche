using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationImpr : MonoBehaviour
{
    public Transform waffer;
    public Transform thisTransform;
    public Rigidbody wafferBody;

    public bool aWaffer;
    public bool aPatron;
    public Transform patron;
    public Rigidbody patronBody;

    public Renderer patronMat;
    public Renderer wafferMat;

    public wafferScript ws;

    public UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable grabPatron;
    public UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable grabWaffer;

    public Material matFin;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.tag =="waffer" && ws.estFini){
            waffer.position = thisTransform.position + thisTransform.TransformDirection(new Vector3(0f, 0.005f,-0.01f));
            waffer.eulerAngles  = new Vector3(0,0,0);
            wafferBody.constraints = RigidbodyConstraints.FreezeAll;
            aWaffer=true;
            grabWaffer.enabled = false;
            }
        if(collision.tag == "patron" && aWaffer){
            patron.position = thisTransform.position + thisTransform.TransformDirection(new Vector3(0f, 0.009f,-0.01f));
            patron.eulerAngles  = new Vector3(0,0,0);
            patronBody.constraints = RigidbodyConstraints.FreezeAll;
            aPatron =true;
            grabPatron.enabled = false;
        }

    }

    public void changeMat(){
        if(aPatron){
            wafferMat.material = patronMat.material;
            grabPatron.enabled = true;
            grabWaffer.enabled = true;
            wafferMat.material = matFin;
            ws.aPatron =true;
        }
    } 
}
