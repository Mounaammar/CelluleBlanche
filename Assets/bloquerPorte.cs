using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloquerPorte : MonoBehaviour
{
    public ModeDeJeuEnum mdj;
    public bool estFermee;
    public Rigidbody porte;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                if((mdj==ModeDeJeuEnum.ESCAPE_GAME) && estFermee){
            porte.constraints = RigidbodyConstraints.FreezeAll;
            }
    }

    void OnTriggerEnter(Collider collision){
        if(collision.tag =="clef"){
            porte.constraints = RigidbodyConstraints.None;
            porte.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}
