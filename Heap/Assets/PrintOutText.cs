using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintOutText : MonoBehaviour
{
    public Text ResolutionText, Running_Gpu_Api_txt, Vsync_Text;

    // Update is called once per frame
    void Update()
    {
        printout();
    }

    void printout(){
        ResolutionText.text         = "ScreenRes: " + getScreenResolution();
        Running_Gpu_Api_txt.text    = "Gpu API: " + getRunning_Gpu_Api_txt();
        Vsync_Text.text             = "Vsync: " + getVsync_Text();
    }

    
    string getScreenResolution(){

        return Screen.currentResolution.ToString();
    }

    string getRunning_Gpu_Api_txt(){
        return SystemInfo.graphicsDeviceType.ToString();
    }

    string getVsync_Text(){
        int vsync = QualitySettings.vSyncCount;
        string returnstring;

        if (vsync == 0)
            returnstring = "InAktiv";
        else
            returnstring = "Aktiv";

        return returnstring;
    }

    void fullscreenSwitch(){
        Screen.fullScreen = !Screen.fullScreen;
    }
}
