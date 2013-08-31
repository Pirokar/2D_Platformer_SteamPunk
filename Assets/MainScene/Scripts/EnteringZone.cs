using UnityEngine;
using System.Collections;

public class EnteringZone : MonoBehaviour {
	
	public static int steamsToOpen = 2;
	static public bool done;
	private bool needSteams;
	static public bool isBack;

	void Start () {
		done = false;
		isBack = false;
		needSteams = false;
	}
	
	void OnTriggerEnter(Collider player) {
		if(!done)
			if(!isBack && player.tag=="Player")
				if(SteamSystem.currentSteams<steamsToOpen)
					needSteams = true;
				else {
					Application.LoadLevelAdditive("FirstLogic");
					Time.timeScale = 0;
				}
	}
	
	void OnTriggerExit(Collider player) {
		if(player.tag=="Player") {
			needSteams = false;
			isBack = false;
		}
	}
	
	void OnGUI() {
		if(needSteams) {
			GUI.Box(new Rect(Screen.width/2-100,Screen.height/2-50,200,100),"");
			GUI.Label(new Rect(Screen.width/2-80,Screen.height/2-40,160,80),"Нужно собрать "+steamsToOpen+" шестеренок, чтобы задействовать механизм");
		}
	}
	
}
