using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 45f;
    public float horizontalInput;
    public float verticalInput;
    public GameObject playerObject;
    public static PlayerController cc;
    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float maxSteeringAngle;
    public float carMaxSpeed = 100;
    public float carCurrentSpeed = 0;
    public WheelController wheelController;

    public GameObject SpawnPoint;

    

    Rigidbody rb;

    // Start is called before the first frame update

    public void Start()
    {
        cc = this;
        rb = GetComponent<Rigidbody>();

    }
   
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        // restart button 
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = SpawnPoint.transform.position;
            //transform.Rotate;
            transform.rotation = Quaternion.Euler(0, 55.418f, 0);
            //SceneManagement.LoadScene("Track1");
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    //    rb.AddForce(Vector3.forward * speed * verticalInput * Time.deltaTime);
    //    //transform.Translate( new Vector3(0,0,1) * Time.deltaTime * speed * verticalInput );
    //    //transform.Translate( Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate( Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );

    }
    [System.Serializable]
    public class AxleInfo
    {
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;
        public bool motor;
        public bool steering;
    }

}
