using UnityEngine;
using System.Collections;

public class DoorMove2 : MonoBehaviour {

	public static bool open;
	private int x;
	public int MovingLength = 300;

	void Start () {
		open = false;
		x = 0;
	}
	
	void Update () {
		if(open) {
			if (x<=MovingLength) {
				transform.position +=(new Vector3(0, 1, 0));
				x += 1;
			}
			else
				open = false;
		}
	}
}
