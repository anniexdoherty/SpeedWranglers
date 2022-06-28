using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 45f;

    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0,0,1);

       horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");
       transform.Translate( Vector3.forward * Time.deltaTime * speed * verticalInput );
       //transform.Translate( Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
       transform.Rotate( Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
    }
}
