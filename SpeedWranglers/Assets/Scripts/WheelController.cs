using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;
    public float turnSpeed = 50f;

    public Rigidbody rb;
    public Camera cam;

    public float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;



    
    
    private void FixedUpdate()
    {
        // forward and reverse acceleration from the vertical access

        currentAcceleration = acceleration * Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(cam.transform.forward.x,0,cam.transform.forward.z) * currentAcceleration);

        // if you press space it applies a break force 
        if(Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakingForce;
            rb.AddForce(new Vector3(cam.transform.forward.x,0,cam.transform.forward.z) * -(1.9f * currentAcceleration));
        }
        else
        {
            currentBreakForce = 0f;
        }
        
        // apply acceleration to the front wheels 
        frontRight.motorTorque = currentAcceleration; 
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        //steering should work 
        /*
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        transform.Rotate( Vector3.up, turnSpeed * currentTurnAngle);

        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
        */
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
