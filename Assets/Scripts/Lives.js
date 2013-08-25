static var maxLives : int = 3;
static var currentLives : int = 3;

function OnGUI() {
	if(currentLives < 0) {
		Time.timeScale = 0;
		GUI.Box(Rect(Screen.width/2 - 50,Screen.height/2 - 40,100,50),"");
		GUI.Label(Rect(Screen.width/2 - 50,Screen.height/2 - 30,100,20),"Конец игры");
		if(GUI.Button(Rect(Screen.width/2 - 50,Screen.height/2+10,100,20),"В меню")) {
			Application.LoadLevel("MainMenu");
			SteamSystem.currentSteams = 1;
			Time.timeScale = 1;
			currentLives = 3;
			SteamSystem.more = false;
		}
	}
}