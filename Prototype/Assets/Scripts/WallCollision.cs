using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "wall") {
			Vector3 dir = col.contacts [0].point - this.transform.position;
			dir.y = 0.0f;
			this.transform.Translate (dir);
//			this.GetComponent<Rigidbody> ().AddForce (dir * 20.0f);
		}
	}
}
