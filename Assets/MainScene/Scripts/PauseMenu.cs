using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public bool exit;
	public bool paused;

	// Use this for initialization
	void Start () {
		exit = false;
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Pause")) {
			if(!paused) {
				Time.timeScale = 0;
				paused = true;
			}
			else {
				Time.timeScale = 1;
				paused = false;
			}
		}
	}
	
	void OnGUI() {
		if(paused) {
			if(GUI.Button(new Rect(Screen.width/2 - 50,Screen.height/2 - 30,100,30), "Продолжить")) {
				Time.timeScale = 1.0f;
				paused = false;
				if(Input.anyKeyDown) {
					paused = false;
				}
			}
			if(GUI.Button(new Rect(Screen.width/2 - 50,Screen.height/2 + 10,100,30), "Меню")) {
				Application.LoadLevel("MainMenu");
				Lives.currentLives = Lives.maxLives;
				SteamSystem.currentSteams = 1;
				Time.timeScale = 0;
	
				
			}
		}
	}
}
