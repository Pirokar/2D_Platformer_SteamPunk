var player : GameObject;
var steam : Transform;

function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		if(SteamSystem.currentSteams==0) {
			Debug.Log("DEAD");
			SteamSystem.currentSteams--;
		}
		else {
			Losing_Steams.bulletsOnMoment = SteamSystem.currentSteams;
			Losing_Steams.damaged = true;	
			player.gameObject.GetComponent(SteamSystem).currentSteams = 0;
			Debug.Log("OOPS");
		}
		Destroy(gameObject);
	}
}