function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(SteamSystem).currentSteams += 1;
		Destroy(gameObject);
		Debug.Log("+1 шестеренка");
	}
}
function Update(){
	transform.Rotate(Vector3(0,0,1));
}