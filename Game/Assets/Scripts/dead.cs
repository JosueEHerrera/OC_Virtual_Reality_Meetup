﻿using UnityEngine;
using System.Collections;

public class dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("space"))
        {
            Application.LoadLevel(0);
        }

	
	}
}
