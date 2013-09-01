using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

	public GameObject scene;
	public Transform l1;
	public Transform l2;
	public Transform l3;
	public Transform l4;
	public Transform l5;
	public Transform em;
	
//	void Start() {
//		
//		em.Transform.position.x = 0;
//	}

	void Update () {
		if (l1.transform.localScale.z<1 && l2.transform.localScale.z<1 && 
			l3.transform.localScale.z<1 && l4.transform.localScale.z<1 && 
			l5.transform.localScale.z<1) {
				EnteringZone2.isBack = true;
				EnteringZone2.done = true;
				SteamSystem.currentSteams -= EnteringZone2.steamsToOpen;
				DoorMove2.open = true;
				Time.timeScale = 1;
				Destroy(scene);
		}
	}
}
