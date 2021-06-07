using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCoin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public static int coinCount = 0;

    TMPro.TMP_Text text;

    void Start() 
    {
        text = GameObject.Find("Items").GetComponent<TMPro.TMP_Text>(); 
    }
    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player"){
            coinCount += 1;
            text.text = "Collect 2 items to enter the next phase \n Items: " + coinCount; 
            Destroy(gameObject);
        }      
    }
}
