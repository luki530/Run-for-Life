using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BM_Space : MonoBehaviour
{
    // Start is called before the first frame update
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
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            _audioSource.Stop();
        }
    }
}
