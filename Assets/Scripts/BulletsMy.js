function Update () {
	Destroy(gameObject,0.5);
}

function OnTriggerEnter(player:Collider) {
	if(player.tag == "Enemy") {
		if(player.gameObject.GetComponent(ImmobileAI).Health>1)
			player.gameObject.GetComponent(ImmobileAI).Health--;
		else
			Destroy(player.gameObject);
		Destroy(gameObject);
		
	}
}