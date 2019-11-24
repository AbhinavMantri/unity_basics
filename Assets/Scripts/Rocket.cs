using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rocketRb;
    private AudioSource audioSource;
    [SerializeField] float rcThrust;
    [SerializeField] float mainThrust;
    // Start is called before the first frame update
    void Start()
    {
        rocketRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        ProcessingInput();
    }

    private void Thrust() {
        if(Input.GetKey(KeyCode.Space)) {
            float mainRotation = mainThrust * Time.deltaTime;
            rocketRb.AddRelativeForce(Vector3.up * mainRotation);
            
            if(!audioSource.isPlaying)
                audioSource.Play();
        } else {
            audioSource.Stop();
        }
    }

    private void ProcessingInput() {
        rocketRb.freezeRotation = true;

        float rotationThrust = rcThrust * Time.deltaTime;

        if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(-Vector3.forward * rotationThrust);
        }
        else if(Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.forward * rotationThrust);
        }

        rocketRb.freezeRotation = false;
    }
}
