using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rocketRb;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rocketRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingInput();
    }

    private void ProcessingInput() {
        if(Input.GetKey(KeyCode.Space)) {
            rocketRb.AddRelativeForce(Vector3.up);
            
            if(!audioSource.isPlaying)
                audioSource.Play();
        } else {
            audioSource.Stop();
        }
        
        if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.forward);
        }
        else if(Input.GetKey(KeyCode.D)) {
            transform.Rotate(-Vector3.forward);
        }
    }
}
