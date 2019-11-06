using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody rocketRb;
    // Start is called before the first frame update
    void Start()
    {
        rocketRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingInput();
    }

    private void ProcessingInput() {
        if(Input.GetKey(KeyCode.Space)) {
            rocketRb.AddRelativeForce(Vector3.up);
        }
        
        if(Input.GetKey(KeyCode.A)) {
            print("Rotating left");
        }
        else if(Input.GetKey(KeyCode.D)) {
            print("Rotating right");
        }
    }
}
