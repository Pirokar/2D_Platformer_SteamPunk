static var steamsToOpen : int = 2;
static var done : boolean = false;
static var needSteams : boolean = false;
static var isBack : boolean = false;

function OnTriggerEnter(player : Collider) {
	if(!done)
		if(!isBack && player.tag=="Player")
			if(SteamSystem.currentSteams<steamsToOpen)
				needSteams = true;
			else {
				Application.LoadLevelAdditive("FirstLogic");
				Time.timeScale = 0;
			}
}

function OnTriggerExit(player : Collider) {
	if(player.tag=="Player") {
		needSteams = false;
		isBack = false;
	}
}

function OnGUI() {
	if(needSteams) {
		GUI.Box(Rect(Screen.width/2-100,Screen.height/2-50,200,100),"");
		GUI.Label(Rect(Screen.width/2-80,Screen.height/2-40,160,80),"Нужно собрать 30 шестеренок, чтобы задействовать механизм");
	}
}
	