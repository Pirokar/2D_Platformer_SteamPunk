var player : GameObject;

function OnTriggerEnter (hit : Collider) {
	Destroy(player.gameObject);
	Lives.currentLives--;
	if(Lives.currentLives>=0) {
		SteamSystem.currentSteams = 1;
		Firearm.ammo = 30;
		Application.LoadLevel("main_scene");
	}
}