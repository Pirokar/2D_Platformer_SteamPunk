using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	
	public GameObject player;
	public Transform steam;

	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			if(SteamSystem.currentSteams==0) {
				Debug.Log("DEAD");
				SteamSystem.currentSteams--;
			}
			else {
				LosingSteams.bulletsOnMoment = SteamSystem.currentSteams;
				LosingSteams.damaged = true;
				SteamSystem.currentSteams = 0;
				
			}
			Destroy(gameObject);
		}
	}
}
