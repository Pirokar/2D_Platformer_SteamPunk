var expToGive : int = 3;

function OnTriggerEnter(player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(Statistics).experience += expToGive;
		Destroy(gameObject);
		Debug.Log("Experience +3");
	}

}