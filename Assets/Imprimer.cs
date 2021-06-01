using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imprimer : MonoBehaviour
{

    public CreationImpr ci; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onSelectEnter(){
        ci.changeMat();

    }
}
