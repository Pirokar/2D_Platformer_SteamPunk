using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public static int maxLives;
	public static int currentLives;

	
	void Start () {
		maxLives = 3;
		currentLives = 3;
	}
	
	void OnGUI () {
		if(currentLives < 0) {
			Time.timeScale = 0;
			GUI.Box(new Rect(Screen.width/2 - 50,Screen.height/2 - 40,100,50),"");
			GUI.Label(new Rect(Screen.width/2 - 50,Screen.height/2 - 30,100,20),"Конец игры");
			if(GUI.Button( new Rect(Screen.width/2 - 50,Screen.height/2+10,100,20),"В меню")) {
				Application.LoadLevel("MainMenu");
				SteamSystem.currentSteams = 1;
				Time.timeScale = 1;
				currentLives = 3;
				SteamSystem.more = false;
			}
		}
	}

}
