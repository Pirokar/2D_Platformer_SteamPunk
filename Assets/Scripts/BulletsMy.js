function Update () {
	Destroy(gameObject,0.15);
}

function OnTriggerEnter(player:Collider) {
	if(player.tag == "Enemy") {
		Destroy(player.gameObject);
		Destroy(gameObject);
	}
}