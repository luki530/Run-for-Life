using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float delay = 0.3f;
    public GameObject cube;

    public static GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",delay, delay);
    }

    void Spawn(){
        clone  = Instantiate(cube, new Vector3(Random.Range(-326,-272), 50, Random.Range(56,224)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0));
        Destroy(clone, 2f);
    }

    // private void OnTriggerExit(Collider other)
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
    }
}
