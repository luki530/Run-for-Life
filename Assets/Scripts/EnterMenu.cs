using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel("Menu");
        }
    }
}
