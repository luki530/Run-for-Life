using UnityEngine;
using System.Threading;
public class Floor: MonoBehaviour
{
    public LevelManager levelManager;

    void Start(){
        levelManager = FindObjectOfType<LevelManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.position = levelManager.currentCheckpoint.transform.position;
            levelManager.RespawnPlayer();
        
        }
    }

}
