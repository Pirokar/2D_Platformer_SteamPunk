var targetToLookAt : Transform;
var rotationSpeed : int = 1;
var bullet : GameObject;
var fireRate : float;
private var lastShotTime : float;
static var x : float = 0;
static var a : int = 1;
var MovingLength : int = 100;
var Health : float = 5;

function Update () {
	if(targetToLookAt && Vector3.Distance(targetToLookAt.position,transform.position) < 15) {
		var rotate = Quaternion.LookRotation(targetToLookAt.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
		var delayTime : int = Time.time;
		var delay = (delayTime/2);
		if (lastShotTime + fireRate < Time.time) {
			Fire ();
		}
	}
	else {
		transform.rotation = Quaternion.identity;
		if (x<=MovingLength) {
			transform.position += a*(Vector3 (0.05, 0, 0));
			x = x + a*1;
		}
		if (x==MovingLength||x==0)
			a*=-1;
	}
}

function Fire () {
	var bullet = Instantiate(bullet, transform.Find("BulletSpawn").transform.position, Quaternion.identity);
	bullet.rigidbody.AddForce(transform.forward*500);	
	lastShotTime = Time.time;
}