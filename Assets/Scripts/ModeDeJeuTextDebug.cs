using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModeDeJeuTextDebug : MonoBehaviour
{
	public TextMeshProUGUI debugTxt;
	public ModeDeJeu modeDeJeu;
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		switch (modeDeJeu.modeDeJeu)
		{
			case ModeDeJeuEnum.JEU_LIBRE:
				debugTxt.text = "JEU_LIBRE";
				break;
			case ModeDeJeuEnum.ESCAPE_GAME:
			default:
				debugTxt.text = "ESCAPE_GAME";
				break;
		}
    }
}
