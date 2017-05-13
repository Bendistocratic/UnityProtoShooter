using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieDeath : MonoBehaviour {

	public AudioSource deathAudio;

	private float destroyTimer = 4.0f;

	// Use this for initialization
	void Start () {
		deathAudio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (destroyTimer > 0.0f)
			destroyTimer -= Time.deltaTime;
		else 
			Destroy(this.gameObject);
	}
}
