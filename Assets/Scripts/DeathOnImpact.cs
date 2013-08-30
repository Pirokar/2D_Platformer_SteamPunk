using UnityEngine;
using System.Collections;

public class DeathOnImpact : MonoBehaviour {
	
	public GameObject player;
	
	void OnTriggerEnter (Collider hit) {
		Destroy(player.gameObject);
		Lives.currentLives--;
		if(Lives.currentLives>=0) {
			SteamSystem.currentSteams = 1;
			Weapon.ammo = 30;
			Application.LoadLevel("main_scene");
		}
	}
}
