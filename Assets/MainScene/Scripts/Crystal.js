var crystalAmount : int = 1;

function OnTriggerEnter (player : Collider) {
	if(player.tag=="Player") {
		player.gameObject.GetComponent(Objective).crystals+=crystalAmount;
		Destroy(gameObject);
		Debug.Log("Player obtained crystal");
	}
}