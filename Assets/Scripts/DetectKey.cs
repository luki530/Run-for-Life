using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKey : MonoBehaviour
{
    [SerializeField] public static int keyCount = 0;
    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player"){
            keyCount += 1;
            Destroy(gameObject);
        }      
    }
}
