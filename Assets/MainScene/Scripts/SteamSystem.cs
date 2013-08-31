using UnityEngine;
using System.Collections;

public class SteamSystem : MonoBehaviour {

	public static int currentSteams;
	public int maxSteams;
	static public bool more;

	void Start () {
		currentSteams = 1;
		maxSteams = 9999;
		more = false;
	}
	
	void Update () {
		if (currentSteams<0&&!more) {
			Time.timeScale = 0;
			Lives.currentLives--;
			more = true;
		}
	}
	
	void OnGUI () {
		if(more&&Lives.currentLives>=0) {
			GUI.Box(new Rect(Screen.width/2-100,Screen.height/2-100,200,30),"Вы умерли");
			GUI.Box(new Rect(Screen.width/2-100,Screen.height/2-65,200,60),"");
			GUI.Label(new Rect(Screen.width/2-90,Screen.height/2-65,200,50),"Попробовать еще раз? Осталось "+Lives.currentLives+" жизней");
			if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/2,50,50),"Да")) {
				Application.LoadLevel("MainScene");
				more = false;
				SteamSystem.currentSteams = 1;
				Time.timeScale = 1;
			}
			if(GUI.Button(new Rect(Screen.width/2+50,Screen.height/2,50,50),"Нет")) {
				Application.LoadLevel("MainMenu");
				more = false;
				SteamSystem.currentSteams = 1;
				Time.timeScale = 1;
				Lives.currentLives = 3;
			}
		}
	}
}