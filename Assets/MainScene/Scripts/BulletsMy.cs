﻿using UnityEngine;
using System.Collections;

public class BulletsMy : MonoBehaviour {
	
	GameObject LosingSteamsSpawn;
	public GameObject steam;
	GameObject floorSteam;

	void Update () {
		Destroy(gameObject,0.5f);
	}
	
	void OnTriggerEnter(Collider player) {
		if(player.tag == "Enemy") {
			if(MobileAI.Health>1)
				MobileAI.Health--;
			else {
				for(int i = 0; i < 5; i++) {
					floorSteam = Instantiate(steam, transform.position, Quaternion.identity) as GameObject;
					floorSteam.rigidbody.AddForce(new Vector3(Random.Range(-70f,100f)/70f, 1, 0)*20000);
				}
				Destroy(player.gameObject);
			}
			Destroy(gameObject);
		}
	}
}