var Projectile: Transform;
var fireRate: float = 0.3;
private var nextFire: float = 2.0;
var Ammo: int = 30;
var empty: boolean = false;

var gunfire: AudioClip;
var reload: AudioClip;

function Update () {
	if(Input.GetButton("Fire1")&&Time.time > nextFire) {
		if(Ammo>0){
			Fire();
		}
		else {
			return;
		}
	}
	if(Input.GetKeyUp("r")) {
		if(empty){
			Reload();
		}
	}
	if(Ammo <= 0)
		empty = true;
	else
		empty = false;
}

function