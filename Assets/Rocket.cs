using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private Rigidbody rigidbody;
    private AudioSource rocketSound;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rocketSound = GetComponent<AudioSource>();
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
            if (!rocketSound.isPlaying)
            {
                rocketSound.Play();
            }
        } else
        {
            rocketSound.Stop();
        }

        // rotating
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
}