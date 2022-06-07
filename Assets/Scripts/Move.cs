using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   

    private void FixedUpdate()
    {
        rb.AddTorque(transform.up * -2000f, ForceMode.Acceleration);
    }
}
