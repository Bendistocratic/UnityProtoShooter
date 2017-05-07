using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

	public GameObject bullet;

	private float cooldown = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && cooldown <= 0.0f) {
			GameObject theBullet = Instantiate (bullet, this.transform.position, this.transform.rotation) as GameObject;
			Rigidbody rbBullet = theBullet.GetComponent<Rigidbody> ();
			Vector3 bDir = new Vector3 (this.transform.position.x, 0.0f, this.transform.position.z);
			rbBullet.AddForce (this.transform.forward * 1000.0f);
			cooldown = 0.3f;
		} else {
			cooldown -= Time.deltaTime;
		}
	}
}
