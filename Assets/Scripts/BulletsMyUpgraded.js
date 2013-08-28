function Update () {
	Destroy(gameObject,0.15);
}

function OnTriggerEnter(player:Collider) {
	if(player.tag == "Enemy") {
		if(player.gameObject.GetComponent(ImmobileAI).Health>1)
			player.gameObject.GetComponent(ImmobileAI).Health-=2;
		else
			Destroy(player.gameObject);
		Destroy(gameObject);
		
	}
}