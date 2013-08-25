static var currentSteams : int = 1;
var maxSteams : int = 9999;
static var more : boolean = false;

function Update () {
	if (currentSteams<0&&!more) {
		Time.timeScale = 0;
		Lives.currentLives--;
		more = true;
	}
}

function OnGUI() {
	if(more&&Lives.currentLives>=0) {
		GUI.Box(Rect(Screen.width/2-100,Screen.height/2-100,200,30),"Вы умерли");
		GUI.Box(Rect(Screen.width/2-100,Screen.height/2-65,200,60),"");
		GUI.Label(Rect(Screen.width/2-90,Screen.height/2-65,200,50),"Попробовать еще раз? Осталось "+Lives.currentLives+" жизней");
		if(GUI.Button(Rect(Screen.width/2-100,Screen.height/2,50,50),"Да")) {
			Application.LoadLevel("main_scene");
			more = false;
			SteamSystem.currentSteams = 1;
			Time.timeScale = 1;
		}
		if(GUI.Button(Rect(Screen.width/2+50,Screen.height/2,50,50),"Нет")) {
			Application.LoadLevel("MainMenu");
			more = false;
			SteamSystem.currentSteams = 1;
			Time.timeScale = 1;
			Lives.currentLives = 3;
		}
	}
}