using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using System;
public class Debug : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI debugTxt;
    public GameObject flacon;

    void Start()
    {
        debugTxt.text = "Hello!";
    }

    // Update is called once per frame
    void Update()
    {
        debugTxt.text = flacon.transform.eulerAngles.x.ToString() + " - " + flacon.transform.eulerAngles.y.ToString() + " - " + flacon.transform.eulerAngles.z.ToString();
    }
}
