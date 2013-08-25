var Projectile: Transform;
var fireRate: float = 0.3;
private var nextFire: float = 2.0;
static var ammo: int = 30;
var ammoLimit : int = 99;
var gunfire: AudioClip;
var reload: AudioClip;

function Awake() {
	ammo = 30;
}
function Update () {
	if(Input.GetButton("Fire1")&&Time.time > nextFire) {
		if(ammo>0)
			Fire();
		else
			return;
	}
}

function Fire() {
	audio.PlayOneShot(gunfire);
	nextFire = Time.time + fireRate;
	var shot = Instantiate(Projectile, transform.position, Quaternion.identity);
	shot.rigidbody.AddForce(transform.forward*3000);
	ammo--;
}