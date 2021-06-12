using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveMenu : MonoBehaviour
{
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel("Run-For-Life");
        }
    }
}
