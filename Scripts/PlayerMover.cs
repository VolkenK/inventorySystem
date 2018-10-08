﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, .2f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -.2f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(.2f, 0, 0);
        }
    }
}