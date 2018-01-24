using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KaboomMic : MonoBehaviour {

	public float detectionRange;
	public float explodeRange;
	public float explodeTime;

	public Text countdownText;

	private bool detected = false;
	private bool inRange = false;
	private bool explode = false;

	public Transform player;

	void Start() {
		countdownText = GetComponent<Text>();
		Detection();
	}
	
	void Update () {

	}

	public void Detection() {
		if(Vector3.Distance(player.position, transform.position) <= detectionRange) {
			detected = true;
			StartCoroutine(Countdown());
		}
	}

	public void Explode() {
 		if(detected && Vector3.Distance(player.position, transform.position) <= explodeRange && explode == true) {
			Destroy(player.gameObject);
		} else {
			detected = false;
			explode = false;
			Detection();
		}
	}
	IEnumerator Countdown() {
        while (true) {
            yield return new WaitForSeconds (explodeTime);
            
            explode = true;
            Explode();
        }
    }
}

