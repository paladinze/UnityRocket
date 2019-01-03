using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
            print("Thrust");
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