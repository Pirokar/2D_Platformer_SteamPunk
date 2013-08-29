var LosingSteamsSpawn : GameObject;
var steam : Transform;

function Update () {
	Destroy(gameObject,0.5);
}

function OnTriggerEnter(player:Collider) {
	if(player.tag == "Enemy") {
		if(player.gameObject.GetComponent(MobileAI).Health>1)
			player.gameObject.GetComponent(MobileAI).Health-=2;
		else {
			for(var i = 0; i < 5; i++) {
				var floorSteam = Instantiate(steam, transform.position, Quaternion.identity);
				floorSteam.rigidbody.AddForce(Vector3(Random.Range(-70.0,100)/70, 1, 0)*20000);
			}
			Destroy(player.gameObject);
		Destroy(gameObject);
		}
	}
}