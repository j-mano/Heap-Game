using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    int Gold;

    // Start is called before the first frame update
    void Start()
    {
        Gold = 0;
    }
    
    public int GetGold(){
        return Gold;
    }

    public void AddGold(int InputGold){
        Gold = Gold + InputGold;
    }

    public void SubtractGold(int InputGold){
        Gold = Gold + InputGold;
    }
}
