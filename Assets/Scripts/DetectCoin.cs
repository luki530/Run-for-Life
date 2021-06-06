using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCoin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static int coinCount = 0;
    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player"){
            coinCount += 1;
            Destroy(gameObject);
        }      
    }
}
