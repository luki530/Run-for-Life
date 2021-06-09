using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

        
        IEnumerator OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {

                yield return new WaitForSeconds(3);
                other.attachedRigidbody.velocity = Vector3.zero;
                other.attachedRigidbody.position = new Vector3(-1393, 235, 220);
                player.transform.position = new Vector3(-1393, 235, 220);
                player.transform.eulerAngles = new Vector3(0f, -90f, 0f);
        
        }
    }
}
