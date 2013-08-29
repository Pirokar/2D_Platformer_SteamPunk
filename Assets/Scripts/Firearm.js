var Projectile: Transform;
var upProjectile : Transform;
var fireRate: float = 0.5;
private var nextFire: float = 1.0;
static var ammo: int = 30;
var ammoLimit : int = 99;
var gunfire: AudioClip;
var steamsToUpgrade : int;

function Awake() {
	ammo = 30;
}
function LateUpdate () {
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
	if(SteamSystem.currentSteams>=steamsToUpgrade)
		var shot = Instantiate(upProjectile, transform.position,Quaternion.identity);
	else
		shot = Instantiate(Projectile, transform.position, Quaternion.identity);
	shot.rigidbody.AddForce(transform.forward*50000);
	ammo--;
}