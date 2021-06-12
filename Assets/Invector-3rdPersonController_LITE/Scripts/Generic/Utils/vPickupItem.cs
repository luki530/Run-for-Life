using UnityEngine;
using System.Collections;

public class vPickupItem : MonoBehaviour
{
    AudioSource _audioSource;
    public AudioClip _audioClip;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {          
            _audioSource.clip = _audioClip;

            _audioSource.Play();
            Destroy(gameObject, _audioClip.length);
        }
    }
}