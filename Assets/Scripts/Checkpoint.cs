using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame updat

    public LevelManager levelManager;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            levelManager.currentCheckpoint = gameObject;
        }
    }
}
