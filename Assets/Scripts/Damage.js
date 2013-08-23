var damage : int = 25;
var player : GameObject;

function OnTriggerEnter(player : Collider) {
	player.gameObject.GetComponent(PlayerHealth).currentHealth -= damage;
	Debug.Log(player.gameObject.GetComponent(PlayerHealth).currentHealth);
}