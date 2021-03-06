﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hardware_Printout : MonoBehaviour
{
    public Text TitleTxt, Graphics_apiTxt, OSTXT, AplicationRamTxt,FpsTxt;

    float framerate = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        printout();
        calcFps();
    }

    void printout(){
        Graphics_apiTxt.text     = Get_Gpi_apirunning();
        OSTXT.text               = GetOs();
        AplicationRamTxt.text    = GetRamAmountSucking();
        FpsTxt.text              = "Framerate: " + GetFramerate();
    }

    void calcFps(){
        framerate = Time.frameCount / Time.time;
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

    float GetFramerate(){
        return framerate;
    }
}
