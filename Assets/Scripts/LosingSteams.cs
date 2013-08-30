using UnityEngine;
using System.Collections;

public class LosingSteams : MonoBehaviour {
	
	public GameObject LosingSteamsSpawn;
	public GameObject steam;
	public static bool damaged;
	public static int bulletsOnMoment;

	void Start () {
		damaged = false;
	}
	
	void Update () {
		if(damaged) {
			GameObject floorSteam;
			for(int i = 0; i < bulletsOnMoment; i++) {
				floorSteam = Instantiate(steam, LosingSteamsSpawn.transform.position, Quaternion.identity) as GameObject;
				floorSteam.rigidbody.AddForce(new Vector3(Random.Range(-70f,100f)/70f, 1, 0)*20000);
			}
			damaged = false;
			bulletsOnMoment = 0;
		}
	}
}
