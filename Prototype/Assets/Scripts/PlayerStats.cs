using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public int health;

	private Renderer rend;
	private float invul = 0.0f;
	private bool isInvul = false;

	// Use this for initialization
	void Start () {
		rend = this.GetComponentInChildren<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0.0f)
			Destroy (this.gameObject);

		if (invul > 0.0f) {
			invul -= Time.deltaTime;
		}

		if (isInvul) {
			StartCoroutine (Blink (5, 0.05f, 0.05f));
			isInvul = false;
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "zombie" && invul <= 0.0f) {
			health -= 1;
			invul = 1.2f;
			isInvul = true;
		}
	}

	IEnumerator Blink(int n, float timeOn, float timeOff) {
		while (n > 0) {
			rend.enabled = true;
			yield return new WaitForSeconds (timeOn);
			rend.enabled = false;
			yield return new WaitForSeconds (timeOff);
			n--;
		}
		rend.enabled = true;
	}
}
