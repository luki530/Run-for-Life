using UnityEngine;

public class Floor: MonoBehaviour
{
    [SerializeField] private Transform spawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bounce"))
        {
            other.attachedRigidbody.position = spawn.position;
            other.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
