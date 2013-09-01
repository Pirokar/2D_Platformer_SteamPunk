using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Ammo : MonoBehaviour {
	
	public AudioClip pick;
	
	public int ammoToGive = 15;

	void OnTriggerEnter(Collider player) {
		if(player.tag == "Player") {
			Weapon.ammo += ammoToGive;
			AudioSource.PlayClipAtPoint(pick, transform.position, 0.3f);
			Destroy(gameObject);
			Debug.Log("Подобрано пуль 15");
		}
	
	}
}
