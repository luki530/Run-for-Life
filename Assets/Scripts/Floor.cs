using UnityEngine;
using System.Threading;
public class Floor: MonoBehaviour
{
    public LevelManager levelManager;

    public AudioClip death;
    AudioSource audioSource;

    void Start(){
        levelManager = FindObjectOfType<LevelManager>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(death, 1F);
            other.attachedRigidbody.velocity = Vector3.zero;
            other.attachedRigidbody.position = levelManager.currentCheckpoint.transform.position;
            levelManager.RespawnPlayer();
        
        }
    }

}
