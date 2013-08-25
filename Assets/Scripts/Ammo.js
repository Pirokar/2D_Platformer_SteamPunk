var ammoToGive : int = 15;

function OnTriggerEnter(player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(Firearm).ammo += ammoToGive;
		Destroy(gameObject);
		Debug.Log("Подобрано пуль 15");
	}

}