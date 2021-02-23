using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class ChangeScen : MonoBehaviour
{
    public void ChangeScene(){
        SceneManager.LoadScene("MainScen");
    }
}
