using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SteamPickUp : MonoBehaviour {
	
	public AudioClip pick;
	
	void Update () {
		transform.Rotate(new Vector3(0,0,1));
	}
	
	void OnTriggerEnter (Collider player) {
		if(player.tag == "Player") {
			SteamSystem.currentSteams += 1;
			AudioSource.PlayClipAtPoint(pick, transform.position, 0.3f);
			Destroy(gameObject);
			Debug.Log("+1 шестеренка");
		}
	}
}
