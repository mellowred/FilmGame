using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaboomMic : MonoBehaviour {

	public float detectionRange;
	public float explodeRange;

	public bool detected = false;
	public bool inRange = false;

	public Transform player;

	
	void Update () {
		Detection();
	}

	public void Detection() {
		if(Vector3.Distance(player.position, transform.position) <= detectionRange) {
			detected = true;
			Debug.Log("detected");
		}

		if(detected && Vector3.Distance(player.position, transform.position) <= explodeRange) {
			Debug.Log("Hurt Player");
		}
	}
}

