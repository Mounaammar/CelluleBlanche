using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public ModeDeJeu mode;
    //public GameObject doorHandle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         switch (mode.modeDeJeu)
		    {
			case ModeDeJeuEnum.JEU_LIBRE:
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
				break;
			case ModeDeJeuEnum.ESCAPE_GAME: // Can’t move the door in that case.
			default:
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
				break;
		    }
    }
}
