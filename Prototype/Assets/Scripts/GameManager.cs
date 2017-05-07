using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject sp1, sp2, sp3, sp4;

	private float wave2 = 30.0f, wave3 = 60.0f, wave4 = 90.0f;

	// Use this for initialization
	void Start () {
		sp1.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (wave2 > 0.0f)
			wave2 -= Time.deltaTime;
		else
			sp2.SetActive (true);
		
		if (wave3 > 0.0f)
			wave3 -= Time.deltaTime;
		else
			sp3.SetActive (true);
		
		if (wave4 > 0.0f)
			wave4 -= Time.deltaTime;
		else
			sp4.SetActive (true);
	}
}
