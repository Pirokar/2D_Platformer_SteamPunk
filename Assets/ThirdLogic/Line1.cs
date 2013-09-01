using UnityEngine;
using System.Collections;

public class Line1 : MonoBehaviour {
	
	public bool clicked;
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject five;
	public GameObject six;
	public GameObject seven;
	public GameObject eight;
	public GameObject nine;
	
	void Update() {
		if(clicked) {
			if(GetComponentInChildren<locking>().click == true)
				GetComponentInChildren<locking>().click = !GetComponentInChildren<locking>().click;
			clicked = false;
		}
			
	}

	
}
