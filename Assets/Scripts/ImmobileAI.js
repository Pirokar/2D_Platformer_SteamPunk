var targetToLookAt : Transform;
var rotationSpeed : int = 1;
var bullet : GameObject;
var fireRate : float;
private var lastShotTime : float;

function Update () {
	if(targetToLookAt && Vector3.Distance(targetToLookAt.position,transform.position) < 10) {
		var rotate = Quaternion.LookRotation(targetToLookAt.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
		var delayTime : int = Time.time;
		var delay = (delayTime/2);
		if (lastShotTime + fireRate < Time.time) {
			Fire ();
		}
	}
}

function Fire () {
	var bullet = Instantiate(bullet, transform.Find("BulletSpawn").transform.position, Quaternion.identity);
	bullet.rigidbody.AddForce(transform.forward*500);	
	lastShotTime = Time.time;
}