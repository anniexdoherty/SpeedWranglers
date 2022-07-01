using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCarSound : MonoBehaviour
{
    AudioSource audioSource;
    public float minPitch = 0.05f;
    public float maxPitch = 4f;
    private float pitchFromCar;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;

    }

    // Update is called once per frame
    void Update()
    {
        pitchFromCar = PlayerController.cc.carCurrentSpeed;
        if (pitchFromCar < minPitch)
            audioSource.pitch = pitchFromCar;
        else
            audioSource.pitch = pitchFromCar;
    }
}