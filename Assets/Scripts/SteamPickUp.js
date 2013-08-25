function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(SteamSystem).currentSteams += 1;
		Destroy(gameObject);
		Debug.Log("+1 шестеренка");
	}
}