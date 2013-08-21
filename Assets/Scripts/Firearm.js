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

function Fire() {
	audio.PlayOneShot(gunfire);
	nextFire = Time.time + fireRate;
	var shot = Instantiate(Projectile, transform.position, Quaternion.identity);
	shot.rigidbody.AddForce(transform.forward*3000);
	Ammo--;
}

function Reload() {
	audio.PlayOneShot(reload);
	Ammo = 30;
}

function OnGUI() {
	GUI.Box(Rect(Screen.width - 100,20,100,80),"");
	GUI.Label(Rect(Screen.width - 100,35,90,20),"Ammo:"+Ammo);
	GUI.Label(Rect(Screen.width - 100,20,90,20),"Health"+PlayerHealth.currentHealth);
	
	if(empty) {
		GUI.contentColor = Color.red;
		GUI.Label(Rect(Screen.width - 100,50,90,20),"RELOAD");
	}
}
@script ExecuteInEditMode()