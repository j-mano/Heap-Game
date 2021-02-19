using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Hardware_Printout : MonoBehaviour
{
    public Text TitleTxt, Graphics_apiTxt, OSTXT, AplicationRamTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        printout();
    }

    void printout(){
        Graphics_apiTxt.text     = Get_Gpi_apirunning();
        OSTXT.text               = GetOs();
        AplicationRamTxt.text    = GetRamAmountSucking();
    }

    string GetOs(){
        return SystemInfo.operatingSystem;
    }

    string Get_Gpi_apirunning(){
        return SystemInfo.graphicsDeviceVersion;
    }

    string GetRamAmountSucking(){
        return "not yet implemented";
    }
}
