static var weaponStrength : int = 3;
static var elementalStrength : int = 3;
static var elementFire = "Fire: ";
static var elementIce = "Ice: ";
static var elementLightning = "Lightning: ";

static var weaponFireRate : float = 0.3;

static var levelModifier : float = 1.1;
static var experience : int = 125;
static var experienceLimit = 150;
static var level : int = 1;
static var levelUp : boolean = false;
static var inven : boolean = false;

static var bool : boolean = false;

function Update() {
	if(experience >= experienceLimit) {
		levelUp = true;
		level++;
	}	
}

function OnGUI() {
	if(GUI.Button (Rect(10,60,100,30), "Status")){
		if(inven)
			inven = !inven;
		bool = !bool;
	}
	if(!bool) {
		GUI.Box(Rect(Screen.width / 2 - 175, Screen.height / 2 - 300,350,350),"Stats");
		GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 270, 350, 350), "Health: " + PlayerHealth.currentHealth);
   	 	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 245, 350, 350), "Strength: " + Statistics.weaponStrength);
   	 	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 245, 350, 350), "Element: " + Statistics.elementFire + Statistics.elementIce);
     	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 200, 350, 350), "Experience: " + Statistics.experience);
       	GUI.Label (Rect (Screen.width / 2 - 25, Screen.height / 2 - 285, 350, 350), "LEVEL: " + Statistics.level);
	}
		
	if(GUI.Button(Rect(10,90,100,30), "Inventory")) {
		inventory = true;
		if(inventory==true) {
			Debug.Log("Uhh");
			GUI.Label(Rect(Screen.width/2 - 175, Screen.height/2 - 270,350,350),"Money: "+MoneySystem.currentMoney);
		}
	}
		
	if(GUI.Button(Rect(10,130,100,30), "Options")) {
		options = true;
	}
	if(GUI.Button(Rect(10,170,100,30), "Exit")) {
		exit = true;
	}
}