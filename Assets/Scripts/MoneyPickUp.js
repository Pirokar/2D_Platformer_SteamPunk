var moneyToGive : int = 3;

function OnTriggerEnter (player : Collider) {
	if(player.tag == "Player") {
		player.gameObject.GetComponent(MoneySystem).currentMoney += moneyToGive;
		Destroy(gameObject);
		Debug.Log("Obtained 3$");
	}
}