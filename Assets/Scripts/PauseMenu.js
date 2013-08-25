var exit : boolean = false;

private var paused : boolean = false;

function Update() {
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

function OnGUI() {
	if(paused) {
		if(GUI.Button(Rect(Screen.width/2 - 50,Screen.height/2 - 30,100,30), "Продолжить")) {
			Time.timeScale = 1.0f;
			paused = false;
			if(Input.GetButtonDown) {
				paused = false;
			}
		}
		if(GUI.Button(Rect(Screen.width/2 - 50,Screen.height/2 + 10,100,30), "Меню")) {
			Application.LoadLevel("MainMenu");
			Lives.currentLives = Lives.maxLives;
			SteamSystem.currentSteams = 1;
			Time.timeScale = 0;

			
		}
	}
}