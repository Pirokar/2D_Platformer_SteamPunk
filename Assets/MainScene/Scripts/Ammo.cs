using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {
	
	public int ammoToGive = 15;

	void OnTriggerEnter(Collider player) {
		if(player.tag == "Player") {
			Weapon.ammo += ammoToGive;
			Destroy(gameObject);
			Debug.Log("Подобрано пуль 15");
		}
	
	}
}
