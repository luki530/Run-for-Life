using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 8;
    [SerializeField] private float jumpForce = 10;

    private bool onGround;

    private void FixedUpdate()
    {
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
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
