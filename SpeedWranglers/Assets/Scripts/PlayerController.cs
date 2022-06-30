using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 45f;
    public Rigidbody rb;
    public float horizontalInput;
    public float verticalInput;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0,0,1);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    //    rb.AddForce(Vector3.forward * speed * verticalInput * Time.deltaTime);
    //    //transform.Translate( new Vector3(0,0,1) * Time.deltaTime * speed * verticalInput );
    //    //transform.Translate( Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate( Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );

    }

}
