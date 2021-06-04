using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
   public float delay3 = 0.6f;
    public float delay2 = 0.45f;
    public float delay1 = 0.3f;

    public GameObject cube;
    private IEnumerator coroutine1, coroutine2, coroutine3;
    private static bool isEnable = false;

    public GameObject clone1, clone2, clone3;

    private GameObject destroy;

    // Start is called before the first frame update
    void Start()
    {
        // coroutine1 = Spawn1();
        // coroutine2 = Spawn2();
        // coroutine3 = Spawn3();

        if (isEnable){
            
        }
        else
        {
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cubes"))
        {
            StartCoroutine("Spawn1");
            StartCoroutine("Spawn2");
            StartCoroutine("Spawn3");
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Cubes"))
        {
            StopCoroutine("Spawn1");
            StopCoroutine("Spawn2");
            StopCoroutine("Spawn3");
                     
        }
    }

    private void FindName(GameObject gameObject)
    {
        
    }

    IEnumerator Spawn1()
    {   
        for(;;)
        {
            clone1 = Instantiate(cube, new Vector3(Random.Range(-326,-272), 50, Random.Range(178,224)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone1, 30.0f);
            yield return new WaitForSeconds( 0.2f );
        }
    }

    IEnumerator Spawn2()
    {   
        for(;;)
        {
            clone2 = Instantiate(cube, new Vector3(Random.Range(-326,-272), 50, Random.Range(112,178)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone1, 30.0f);
            yield return new WaitForSeconds( 0.35f );
        }
    }

    IEnumerator Spawn3()
    {   
        for(;;)
        {
            clone3 = Instantiate(cube, new Vector3(Random.Range(-326,-272), 50, Random.Range(56,112)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone1, 30.0f);
            yield return new WaitForSeconds( 0.5f );
        }

    }
    void Update()
    {

    }
}
