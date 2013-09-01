using UnityEngine;
using System.Collections;

public class BulletsEnemy : MonoBehaviour {

	void Update () {
		Destroy(gameObject,2);
	}
	
	void OnTriggerEnter (Collider player) {
		if(player.tag == "Thing") {
			Destroy(gameObject);
		}
	}
	
}