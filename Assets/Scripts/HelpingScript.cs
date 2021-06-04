using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainCamera;

    public bool isEnable = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cubes"))
        {
            isEnable = true;
            
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Cubes"))
        {
            isEnable = false;
            // Destroy(Cubes.clone);
                     
        }
    }
    
}
