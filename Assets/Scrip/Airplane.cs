using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float enginePower = 30f;
    [SerializeField] float liftBooster = 0.5f;
    [SerializeField] float drag = 0.001f;
    [SerializeField] float angulaerDrag = 0.001f;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * enginePower);
        Vector3 lift = Vector3.Project(rb.linearVelocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);
        rb.linearDamping = rb.linearVelocity.magnitude * drag;
        rb.angularDamping = rb.angularVelocity.magnitude * angulaerDrag;
        
       
    }
}
