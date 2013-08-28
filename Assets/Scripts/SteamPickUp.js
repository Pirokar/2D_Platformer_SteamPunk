function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(SteamSystem).currentSteams += 30;
		Destroy(gameObject);
		Debug.Log("+1 шестеренка");
	}
}