using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1Spawner : MonoBehaviour {

	public GameObject zombie;

	private float counter;

	// Use this for initialization
	void Start () {
		counter = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter <= 0.0f) {
			Instantiate (zombie, this.transform.position, Quaternion.identity);
			counter = 5.0f;
		} else {
			counter -= Time.deltaTime;
		}
	}
}
