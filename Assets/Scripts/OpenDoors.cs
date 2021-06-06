using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other) {
        if (DetectCoin.coinCount == 2) {
            Destroy(gameObject);
        }
        
    }
}