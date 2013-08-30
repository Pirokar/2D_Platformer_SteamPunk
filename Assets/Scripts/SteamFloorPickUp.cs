using UnityEngine;
using System.Collections;

public class SteamFloorPickUp : MonoBehaviour {

	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			SteamSystem.currentSteams += 1;
			Destroy(transform.parent.gameObject);
			Debug.Log("+1 шестеренка");
		}
	}
}
