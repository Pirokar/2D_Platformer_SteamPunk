using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	
	public GameObject player;
	public Transform steam;

	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			Debug.Log("ANAL");
			if(SteamSystem.currentSteams==0) {
				Debug.Log("DEAD");
				SteamSystem.currentSteams--;
			}
			else {
				LosingSteams.bulletsOnMoment = SteamSystem.currentSteams;
				LosingSteams.damaged = true;
				Debug.Log("ANAL");
				SteamSystem.currentSteams = 0;
				
			}
			Destroy(gameObject);
		}
	}
}
