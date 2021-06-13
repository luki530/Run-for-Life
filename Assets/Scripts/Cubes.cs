using System.Collections;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float delay3 = 0.6f;
    public float delay2 = 0.45f;
    public float delay1 = 0.3f;

    public GameObject cube;

    public GameObject clone1, clone2, clone3;


    // Start is called before the first frame update
    void Start()
    {

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
            clone1 = Instantiate(cube, new Vector3(Random.Range(-1419.8f, -1365.8f), 257, Random.Range(162,208)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone1, 15.0f);
            yield return new WaitForSeconds( 0.1f );
        }
    }

    IEnumerator Spawn2()
    {   
        for(;;)
        {
            clone2 = Instantiate(cube, new Vector3(Random.Range(-1419.8f, -1365.8f), 257, Random.Range(96,162)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone2, 25.0f);
            yield return new WaitForSeconds( 0.15f );
        }
    }

    IEnumerator Spawn3()
    {   
        for(;;)
        {
            clone3 = Instantiate(cube, new Vector3(Random.Range(-1419.8f, -1365.8f), 257, Random.Range(40,96)), new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            Destroy(clone3, 35.0f);
            yield return new WaitForSeconds( 0.4f );
        }

    }
}
