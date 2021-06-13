using System.Collections;
using UnityEngine;

public class Teleport_1 : MonoBehaviour
{

        public GameObject player;

        
        IEnumerator OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {

                yield return new WaitForSeconds(3);
                other.attachedRigidbody.velocity = Vector3.zero;
                other.attachedRigidbody.position = new Vector3(521.5f,20,-119);
                player.transform.position = new Vector3(521.5f,20,-119);
                player.transform.eulerAngles = new Vector3(0f, -90f, 0f);
        
        }
    }
}
