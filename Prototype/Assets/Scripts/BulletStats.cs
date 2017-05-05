﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStats : MonoBehaviour {

	private float timeLimit = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLimit <= 0.0f)
			Destroy (this.gameObject);
		else
			timeLimit -= Time.deltaTime;
	}
}
