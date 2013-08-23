var resume : boolean = false;
var status : boolean = false;
var inventory : boolean = false;
var options : boolean = false;
var exit : boolean = false;

private var paused : boolean = false;
private var bool : boolean = false;

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
			bool = true;
			if(Input.GetButtonDown) {
				paused = false;
			}
		}
		if(GUI.Button(Rect(10,50,100,30),"Status")) {
			bool = !bool;
			status = true;
		}
		if(!bool) {
			GUI.Box(Rect(Screen.width / 2 - 175, Screen.height / 2 - 300,350,350),"Stats");
			GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 270, 350, 350), "Health: " + PlayerHealth.currentHealth);
   	 		GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 245, 350, 350), "Strength: " + Statistics.weaponStrength);
   	 		GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 220, 350, 350), "Element: " + Statistics.elementFire + Statistics.elementIce);
     		GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 200, 350, 350), "Experience: " + Statistics.experience);
      	 	GUI.Label (Rect (Screen.width / 2 - 25, Screen.height / 2 - 285, 350, 350), "LEVEL: " + Statistics.level);
		}
		if(GUI.Button(Rect(10,90,100,30), "Inventory")) {
			inventory = !inventory;
		}
		if(inventory) {
			Debug.Log("Uhh");
			GUI.Box(Rect(Screen.width/2 - 175, Screen.height/2 - 270,350,350), "Inventory");
			GUI.Label(Rect(Screen.width/2 - 175, Screen.height/2 - 270,350,350),"Money: "+MoneySystem.currentMoney);
		}
		if(GUI.Button(Rect(10,130,100,30), "Options")) {
			options = true;
		}
		if(GUI.Button(Rect(10,170,100,30), "Exit")) {
			exit = true;
		}
	}
}