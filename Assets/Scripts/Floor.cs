using UnityEngine;
using System.Threading;
public class Floor: MonoBehaviour
{
    [SerializeField] private Transform spawn;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // other.attachedRigidbody.isKinematic = true;
            other.attachedRigidbody.velocity = Vector3.zero;
            

            // other.attachedRigidbody.isKinematic = false;
            player.transform.position = spawn.position;
            player.transform.eulerAngles = new Vector3(0f, -90f, 0f);
            other.attachedRigidbody.position = spawn.position;
            
        }
    }
}
