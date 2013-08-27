var LosingSteamsSpawn : GameObject;
var steam : Transform;
static var damaged : boolean = true;
static var bulletsOnMoment : int;

function Update() {
	if(damaged) {
		for(var i = 0; i < bulletsOnMoment; i++) {
			var floorSteam = Instantiate(steam, transform.position, Quaternion.identity);
			floorSteam.rigidbody.AddForce(Vector3(Random.Range(-100.0,100)/100, Random.Range(0.0,1.0), 0)*800);
		}
		damaged = false;
		bulletsOnMoment = 0;
	}
}