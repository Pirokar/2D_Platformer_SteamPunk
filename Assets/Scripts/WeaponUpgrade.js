static var weaponStrength : float = 1.5;
static var weaponFireRate : float = 0.3;
static var elementalUpgrade : float = 0;
var bool : boolean = false;

//function OnGUI() {
//	if(GUI.Button (Rect(Screen.width - 100,0,100,20), "Status")){
//		bool = !bool;
//	}
//	if(!bool) {
//		GUI.Box(Rect(Screen.width / 2 - 175, Screen.height / 2 - 300,350,350),"Stats");
//		GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 275, 350, 350), "Health: " + PlayerHealth.currentHealth);
//       	GUI.Label (Rect (Screen.width / 2 - 175, Screen.height / 2 - 260, 350, 350), "Strength: " + weaponStrength);
//	}
//}