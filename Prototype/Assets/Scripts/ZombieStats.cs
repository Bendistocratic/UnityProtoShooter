using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieStats : MonoBehaviour {

	private GameObject player;
	private NavMeshAgent nma;
	private Vector3 dest;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("character");
		nma = this.GetComponent<NavMeshAgent> ();
		dest = nma.destination;
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (dest, player.transform.position) > 1.0f) {
			nma.destination = player.transform.position;
			dest = player.transform.position;
		}
	}
}
