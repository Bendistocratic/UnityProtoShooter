using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

/*	void Update() {
		float x = Input.GetAxis ("Horizontal") * 150.0f * Time.deltaTime;
		float z = Input.GetAxis ("Vertical") * 3.0f * Time.deltaTime;

		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);
	} */

	void FixedUpdate() {
		float x = Input.GetAxis ("Horizontal") * 150.0f * Time.deltaTime;
		float z = Input.GetAxis ("Vertical") * 3.0f * Time.deltaTime;
	}
}
