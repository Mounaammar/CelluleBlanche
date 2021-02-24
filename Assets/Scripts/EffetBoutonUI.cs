using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffetBoutonUI : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEngine.UI.Button UiButton;
    public string infos;

    private bool estActif = false;

   
    
    void Start()
    {
        Text t = GameObject.Find("Information").GetComponent<UnityEngine.UI.Text>(); 
        UiButton.onClick.AddListener(()=>{
            if(!estActif){
            estActif =true;
            t.text = infos;}
        else{
            t.text = "";
            estActif = false;
        }
    });
        
    }
    
   
   
}
