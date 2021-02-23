using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carackterControllsWASD : MonoBehaviour
{
    float movespeedx = 0.0f, movespeedy = 0.0f;

    // Update is called once per frame
    void Update()
    {
        wasdControlls();
    }

    void wasdControlls(){
        movespeedy = movespeedy / 2;
        movespeedx = movespeedx / 2;

        if (Input.GetKey("w"))
        {
            movespeedy = movespeedy + 0.01f;
        }

        if (Input.GetKey("s"))
        {
            movespeedy = movespeedy - 0.01f;
        }

        if (Input.GetKey("a"))
        {
            movespeedx = movespeedx - 0.01f;
        }

        if (Input.GetKey("d"))
        {
            movespeedx = movespeedx + 0.01f;
        }

        this.transform.position = new Vector3(transform.position.x + movespeedx, transform.position.y + movespeedy);
    }
}
