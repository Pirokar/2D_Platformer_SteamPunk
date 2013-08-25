var player : GameObject;

function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		if(SteamSystem.currentSteams==0) {
			Debug.Log("DEAD");
			SteamSystem.currentSteams--;
		}
		else {
			player.gameObject.GetComponent(SteamSystem).currentSteams = 0;
			Debug.Log("OOPS");
		}
		Destroy(gameObject);
	}
}