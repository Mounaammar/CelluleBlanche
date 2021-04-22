using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ModeDeJeuEnum { ESCAPE_GAME, JEU_LIBRE }

public class ModeDeJeu : MonoBehaviour
{
	private ModeDeJeuEnum modeDeJeu;
    // Start is called before the first frame update
    void Start()
    {
        modeDeJeu = ModeDeJeuEnum.ESCAPE_GAME;
    }

	public void setModeDeJeu(string mode)
	{
		switch (mode)
		{
			case "JEU_LIBRE":
				modeDeJeu = ModeDeJeuEnum.JEU_LIBRE;
				break;
			case "ESCAPE_GAME":
			default:
				modeDeJeu = ModeDeJeuEnum.ESCAPE_GAME;
				break;
		}
	}
	
    // Update is called once per frame
    void Update()
    {
        
    }
}
