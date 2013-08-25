function Update () {
	Destroy(gameObject,3);
}

function OnTriggerEnter(player:Collider) {
	if(player.tag == "Enemy") {
		Destroy(player.gameObject);
		Destroy(gameObject);
	}
}