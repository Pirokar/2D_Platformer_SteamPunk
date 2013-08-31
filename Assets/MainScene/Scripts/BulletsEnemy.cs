using UnityEngine;
using System.Collections;

public class BulletsEnemy : MonoBehaviour {

	void Update () {
		Destroy(gameObject,3);
	}
	
	void OnTriggerEnter (Collider player) {
		if(player.tag == "Thing") {
			Destroy(gameObject);
		}
	}
	
}