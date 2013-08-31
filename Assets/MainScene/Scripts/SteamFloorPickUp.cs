using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SteamFloorPickUp : MonoBehaviour {
	
	public AudioClip pick;

	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			SteamSystem.currentSteams += 1;
			AudioSource.PlayClipAtPoint(pick, transform.position, 0.3f);
			Destroy(transform.parent.gameObject);
			Debug.Log("+1 шестеренка");
		}
	}
}
