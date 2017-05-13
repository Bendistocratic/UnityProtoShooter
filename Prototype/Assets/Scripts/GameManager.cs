using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject sp1, sp2, sp3, sp4;
	public GameObject player;

	private bool hasLost = false, hasWon = false;
	private bool isWave2, isWave3, isWave4;
	private float gameTimer = 0.0f;
	private float wave2 = 30.0f, wave3 = 60.0f, wave4 = 90.0f;
	private int waveCounter = 1;
	private float displayTimer = 0.0f;
	private bool shouldDisplay = false;

	// Use this for initialization
	void Start () {
		sp1.SetActive (true);
		displayTimer = 4.0f;
		isWave2 = isWave3 = isWave4 = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameTimer > wave2 && isWave2) {
			sp2.SetActive (true);
			shouldDisplay = true;
			waveCounter = 2;
			isWave2 = false;
		}
		if (gameTimer > wave3 && isWave3) {
			sp3.SetActive (true);
			shouldDisplay = true;
			waveCounter = 3;
			isWave3 = false;
		}
		if (gameTimer > wave4 && isWave4) {
			sp4.SetActive (true);
			shouldDisplay = true;
			waveCounter = 4;
			isWave4 = false;
		}
			
		if (!hasLost)
			gameTimer += Time.deltaTime;	

		if (shouldDisplay && !hasLost) {
			displayTimer = 4.0f;
			shouldDisplay = false;
		}

		if (player == null) {
			hasLost = true;
		}

		if (gameTimer > 120.0f) {
			hasWon = true;
			sp1.SetActive (false);
			sp2.SetActive (false);
			sp3.SetActive (false);
			sp4.SetActive (false);
		}
	}

	void OnGUI() {
		GUIStyle style = GUI.skin.GetStyle ("Label");
		style.alignment = TextAnchor.MiddleCenter;
		if (displayTimer > 0.0f) {
			if (waveCounter == 1) {
				GUI.contentColor = Color.red;
				GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Wave 1");
				GUI.skin.label.fontSize = 40;
			} else if (waveCounter == 2) {
				GUI.contentColor = Color.red;
				GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Wave 2");
				GUI.skin.label.fontSize = 40;
			} else if (waveCounter == 3) {
				GUI.contentColor = Color.red;
				GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Wave 3");
				GUI.skin.label.fontSize = 40;
			} else {
				GUI.contentColor = Color.red;
				GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "Wave 4");
				GUI.skin.label.fontSize = 40;
			}
			displayTimer -= Time.deltaTime;
		}

		if (hasLost) {
			GUI.contentColor = Color.red;
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "You Lose");
			GUI.skin.label.fontSize = 120;
		}

		if (hasWon) {
			GUI.contentColor = Color.green;
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "You Win!");
			GUI.skin.label.fontSize = 120;
		}
	}
}
