using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    [SerializeField] public GameObject currentCheckpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void RespawnPlayer()
    {
        player.transform.position = currentCheckpoint.transform.position;
        player.transform.eulerAngles = new Vector3(0f, -90f, 0f);
        
    }
}
