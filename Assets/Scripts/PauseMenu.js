var paused : boolean = false;
private var myCheck : boolean = false;
var weaponStrength : float = 1.5;
var weaponFireRate : float = 0.3;
var elementalUpgrade : float = 0;
var levelModifier : float = 1.1;
var experience : int = 125;
var level : int = 1;
var bool : boolean = false;
var inven : boolean = false;

private var levelUp : boolean = false;

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
		if(GUI.Button(Rect(10,10,100,30), "Resume")) {
			Time.timeScale = 1.0f;
			paused = false;
			S = "Playing!";
			if(Input.GetButtonDown) {
				paused = false;
			}
		}
		if(GUI.Button (Rect(10,60,100,30), "Status")){
			if(inven)
				inven = !inven;
			bool = !bool;
		}
		if(!bool) {
			GUI.Box(Rect(Screen.width / 2 - 175, Screen.height / 2 - 300,350,350),"Stats");
			GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 270, 350, 350), "Health: " + PlayerHealth.currentHealth);
      	 	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 245, 350, 350), "Strength: " + weaponStrength);
      	 	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 220, 350, 350), "Elemental: " + elementalUpgrade);
      	 	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 200, 350, 350), "Experience: " + experience);
      	 	GUI.Label (Rect (Screen.width / 2 - 25, Screen.height / 2 - 285, 350, 350), "LEVEL: " + level);
		}
		
		if(GUI.Button(Rect(10,110,100,30), "Inventory")) {
			if(!bool)
				bool = !bool;
			inven = !inven;
		}
		if(inven==true) {
			GUI.Box(Rect(Screen.width/2 - 175, Screen.height/2 - 300,350,350),"Inventory");
			GUI.Label(Rect(Screen.width/2 - 175, Screen.height/2 - 270,350,350),"Money: "+MoneySystem.currentMoney);
		}
		
		if(GUI.Button(Rect(10,160,100,30), "Options")) {
		}
		if(GUI.Button(Rect(10,220,100,30), "Exit")) {
		}
	}
}