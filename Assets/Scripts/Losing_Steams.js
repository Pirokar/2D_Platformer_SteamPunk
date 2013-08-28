var LosingSteamsSpawn : GameObject;
var steam : Transform;
static var damaged : boolean = true;
static var bulletsOnMoment : int;

function Update() {
	if(damaged) {
		for(var i = 0; i < bulletsOnMoment; i++) {
			var floorSteam = Instantiate(steam, transform.position, Quaternion.identity);
			floorSteam.rigidbody.AddForce(Vector3(Random.Range(-70.0,100)/70, 1, 0)*800);
		}
		damaged = false;
		bulletsOnMoment = 0;
	}
}