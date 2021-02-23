using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardware : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getFullSpecifikations(){
        // todo: Add in an good way to get full specifikations of system thats later can be compared tp system requiments.
    }

    string GetOs(){
        return SystemInfo.operatingSystem;
    }

    string Get_Gpi_apirunning(){
        return SystemInfo.graphicsDeviceVersion;
    }

    int GetSystRam(){
        return SystemInfo.systemMemorySize;
    }

    string RunningCpuArcth(){
        return "Not implemented";
    }

    string cpu(){
        return "Not implemented";
    }
}
