﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidbody : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}

	void Update() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		if (movement != Vector3.zero) {
			rb.MoveRotation (Quaternion.Slerp (new Quaternion (0.0f, transform.rotation.y, 0.0f, transform.rotation.w), Quaternion.LookRotation (movement), Time.deltaTime * turnSpeed));
		}
		/*
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y,
			Camera.main.transform.position.z - transform.position.z));
		transform.LookAt (mousePos);
		*/

		rb.velocity = movement * moveSpeed;
	}
}
