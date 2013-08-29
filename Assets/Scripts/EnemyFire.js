var targetToLookAt : Transform;
var rotationSpeed : int = 1;
var bullet : GameObject;
var fireRate : float;
private var lastShotTime : float;
static var isFire : boolean;

function Update () {
	if(targetToLookAt && Vector3.Distance(targetToLookAt.position,transform.position) < 600) {
		isFire = true;
		var rotate = Quaternion.LookRotation(targetToLookAt.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
		var delayTime : int = Time.time;
		var delay = (delayTime/2);
		if (lastShotTime + fireRate < Time.time) {
			Fire ();
		}
	}
	else
		isFire = false;
}

function Fire () {
	var bullet = Instantiate(bullet, transform.position, Quaternion.identity);
	bullet.rigidbody.AddForce(transform.forward*20000);	
	lastShotTime = Time.time;
}