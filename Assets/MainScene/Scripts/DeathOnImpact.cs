using UnityEngine;
using System.Collections;

public class DeathOnImpact : MonoBehaviour {
	
	public GameObject player;
	
	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			Destroy(player.gameObject);
			Lives.currentLives--;
			if(Lives.currentLives>=0) {
				SteamSystem.currentSteams = 1;
				Weapon.ammo = 30;
				Application.LoadLevel("MainScene");
			}
		}
	}
}
