using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour
{
    public GameObject TrapDoor;
    public GameObject Trigger;

    void OnTriggerEnter(Collider other) 
    {
        TrapDoor.GetComponent<Animation>().Play("TrapDoor");
        Trigger.GetComponent<Collider>().enabled = false;
        
    }


}