function Update () {
	Destroy(gameObject,3);
}

function OnTriggerEnter(other:Collider) {
	if(other.gameObject.CompareTag("Enemy")) {
		other.gameObject.SendMessage("OnDamage",null);
		Destroy(gameObject);
	}
}