using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

using TMPro;

public class Porte : MonoBehaviour
{
    public GameObject door;
    public ModeDeJeu mdj;
    public bool isLocked = false;
    private enum DoorState
    {
        OPENED,
        CLOSED
    }

    private DoorState state = DoorState.CLOSED;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animate()
    {
        if (mdj.modeDeJeu == ModeDeJeuEnum.JEU_LIBRE || mdj.modeDeJeu == ModeDeJeuEnum.ESCAPE_GAME && !isLocked)
        {
            Animator doorAnimator = door.GetComponent<Animator>();

            AnimatorStateInfo currentState = doorAnimator.GetCurrentAnimatorStateInfo(0);
            if (currentState.fullPathHash == Animator.StringToHash("Base Layer.Fermée") || currentState.fullPathHash == Animator.StringToHash("Base Layer.Ouverte"))
            {
                door.GetComponent<BoxCollider>().enabled = false;

                switch (state)
                {
                    case DoorState.CLOSED:
                        door.GetComponent<Animator>().Play("OuvrirPorte", 0, 0.0f);
                        state = DoorState.OPENED;
                        break;
                    case DoorState.OPENED:
                        door.GetComponent<Animator>().Play("FermerPorte", 0, 0.0f);
                        state = DoorState.CLOSED;
                        break;
                }

                door.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }
}