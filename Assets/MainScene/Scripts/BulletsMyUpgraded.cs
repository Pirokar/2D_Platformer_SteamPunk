using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class BulletsMyUpgraded : MonoBehaviour {
	
	GameObject LosingSteamsSpawn;
	public GameObject steam;
	GameObject floorSteam;
	public AudioClip pick;
	public AudioClip pick2;

	void Update () {
		Destroy(gameObject,0.5f);
	}
	
	void OnTriggerEnter(Collider player) {
		if(player.tag == "Thing") {
			Destroy(gameObject);
		}
		if(player.tag == "Enemy") {
			if(player.gameObject.GetComponent<MobileAI>().Health>1) {
				player.gameObject.GetComponent<MobileAI>().Health-=2;
				AudioSource.PlayClipAtPoint(pick2, transform.position, 0.3f);
			}
			else {
				for(int i = 0; i < 5; i++) {
					floorSteam = Instantiate(steam, transform.position, Quaternion.identity) as GameObject;
					floorSteam.rigidbody.AddForce(new Vector3(Random.Range(-70f,100f)/70f, 1, 0)*20000);
				}
				AudioSource.PlayClipAtPoint(pick, transform.position, 0.3f);
				Destroy(player.gameObject);
			}
			Destroy(gameObject);
		}
	}
}