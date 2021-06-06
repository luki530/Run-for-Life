using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 8;
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float torque = 8;

    private bool onGround;

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        onGround = false;
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.down, transform.localScale.y / 2 + 0.05f);
        foreach (RaycastHit hit in hits)
        {
            if (hit.transform != transform)
            {
                onGround = true;
            }
        }

        if (onGround == false)
        {
            return;
        }
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontal, 0, vertical) * speed;
        rb.AddForce(force);
        rb.AddTorque (Vector3.up * torque * moveHorizontal);
        rb.AddTorque (Vector3.up * torque * moveVertical); 
    }

    void OnTriggerStay(Collider other){
         if (other.gameObject.tag == "IceFloor") {
             GetComponent<Collider>().material.dynamicFriction = 0;
         }
     }
    
    void Update()
    {
        if (Input.GetButtonDown("R") && onGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
