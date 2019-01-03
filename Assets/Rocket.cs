using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	} 
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput ()
    {
        // forward and backward
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
        }

        // rotating
        if (Input.GetKey(KeyCode.D))
        {
            print("Turn Right");
        } else if (Input.GetKey(KeyCode.A))
        {
            print("Turn Left");
        }
    }
}