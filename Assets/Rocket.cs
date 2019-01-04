using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private Rigidbody rigidbody;
    private AudioSource rocketSound;
    [SerializeField] private float boostPower = 100f;
    [SerializeField] private float rotatePower = 100f;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rocketSound = GetComponent<AudioSource>();
	} 
	
	// Update is called once per frame
	void Update () {
        Thrust();
        Rotate();
	}

    private void Thrust()
    {
        // forward and backward
        if (Input.GetKey(KeyCode.Space))
        {
            float moveThisFrame = boostPower * Time.deltaTime;
            Vector3 moveAxis = Vector3.up;

            rigidbody.AddRelativeForce(moveAxis * moveThisFrame);
            if (!rocketSound.isPlaying)
            {
                rocketSound.Play();
            }
        }
        else
        {
            rocketSound.Stop();
        }
    }

    private void Rotate()
    {
        // disable physics during manual rotation
        rigidbody.freezeRotation = true;
        
        float rotationThisFrame = rotatePower * Time.deltaTime;

        // rotating
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 rotateAxis = Vector3.forward;
            transform.Rotate(rotateAxis * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 rotateAxis = -Vector3.forward;
            transform.Rotate(rotateAxis * rotationThisFrame);
        }

        // enable physics after manual rotation
        rigidbody.freezeRotation = false;
    }

}