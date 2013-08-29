var player : GameObject;
var steam : Transform;

function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		Debug.Log("ANAL");
		if(SteamSystem.currentSteams==0) {
			Debug.Log("DEAD");
			SteamSystem.currentSteams--;
		}
		else {
			Losing_Steams.bulletsOnMoment = SteamSystem.currentSteams;
			Losing_Steams.damaged = true;
			Debug.Log("ANAL");
			player.gameObject.GetComponent(SteamSystem).currentSteams = 0;
			
		}
		Destroy(gameObject);
	}
}