using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other) {
        if (DetectKey.keyCount == 5) {
            Destroy(gameObject);
        }
        
    }
}
