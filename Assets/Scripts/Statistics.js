static var weaponStrength : int = 3;
static var elementalStrength : int = 3;
static var elementFire = "Fire: ";
static var elementIce = "Ice: ";
static var elementLightning = "Lightning: ";
static var weaponFireRate : float = 0.3;
static var levelModifier : float = 1.1;

static var bool : boolean = false;

function Update() {
}
function OnGUI() {
	if(SteamSystem.more==false&&Lives.currentLives >= 0) {
		GUI.Box(Rect(Screen.width - 150,0,150,80),"");
		GUI.Label(Rect(Screen.width - 150,-3,130,20),"Пули:"+Firearm.ammo);
		GUI.Label(Rect(Screen.width - 150,20,130,20),"Шестеренки: "+ SteamSystem.currentSteams);
		GUI.Box(Rect(0,0,70,50),"Жизни");
		GUI.Label(Rect(6,20,70,20),"Жизни: "+Lives.currentLives);
	}
}