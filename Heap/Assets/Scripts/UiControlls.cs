using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControlls : MonoBehaviour
{
    public GameObject InterfaceMeny;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MenyBtns();
        CheckNumber();
    }

    void CheckNumber(){

    }

    void MenyBtns(){
        if (Input.GetKeyDown("space"))
        {
            InterfaceMeny.SetActive(!InterfaceMeny.activeSelf);
        }
    }
}
