using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	float boolya;
	public AudioSource musicClip;
	
	void Update () {
		if(boolya != Time.timeScale) {
			if(Time.timeScale == 0)
				musicClip.Pause();
			else
				musicClip.Play ();
			boolya = Time.timeScale;
		}
	}
}
