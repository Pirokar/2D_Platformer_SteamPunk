using UnityEngine;
using System.Collections;

public class SteamPickUp : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,0,1));
	}
	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			SteamSystem.currentSteams += 1;
			Destroy(gameObject);
			Debug.Log("+1 шестеренка");
		}
	}
}
