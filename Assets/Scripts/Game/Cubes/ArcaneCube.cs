﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneCube : Cube {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ArcaneBolt")
            Destroy(gameObject);

        print("omg it hit me");
    }
}
