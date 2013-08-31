using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {
	
	public GameObject scene;
	public Transform tile1;
	public Transform tile2;
	public Transform tile3;
	public Transform tile4;
	public Transform tile5;
	public Transform tile6;
	public Transform tile7;
	public Vector3 p1;
	public Vector3 p2;
	public Vector3 p3;
	public Vector3 p4;
	public Vector3 p5;
	public Vector3 p6;
	public Vector3 p7;

	void Start () {
		p1 = new Vector3(0,0,0);
		p2 = new Vector3(0,1,0);
		p3 = new Vector3(1,1,0);
		p4 = new Vector3(1,2,0);
		p5 = new Vector3(2,2,0);
		p6 = new Vector3(2,3,0);
		p7 = new Vector3(3,3,0);
	}
	
	void Update () {
		if ((tile1.position==p1||tile1.position==p2||tile1.position==p3||tile1.position==p4||tile1.position==p5||tile1.position==p6||tile1.position==p7)&&
		(tile2.position==p1||tile2.position==p2||tile2.position==p3||tile2.position==p4||tile2.position==p5||tile2.position==p6||tile2.position==p7)&&
		(tile3.position==p1||tile3.position==p2||tile3.position==p3||tile3.position==p4||tile3.position==p5||tile3.position==p6||tile3.position==p7)&&
		(tile4.position==p1||tile4.position==p2||tile4.position==p3||tile4.position==p4||tile4.position==p5||tile4.position==p6||tile4.position==p7)&&
		(tile5.position==p1||tile5.position==p2||tile5.position==p3||tile5.position==p4||tile5.position==p5||tile5.position==p6||tile5.position==p7)&&
		(tile6.position==p1||tile6.position==p2||tile6.position==p3||tile6.position==p4||tile6.position==p5||tile6.position==p6||tile6.position==p7)&&
		(tile7.position==p1||tile7.position==p2||tile7.position==p3||tile7.position==p4||tile7.position==p5||tile7.position==p6||tile7.position==p7)) {
			EnteringZone.isBack = true;
			EnteringZone.done = true;
			SteamSystem.currentSteams -= EnteringZone.steamsToOpen;
			DoorMove.open = true;
			Time.timeScale = 1;
			Destroy(scene);
		}
	}
}