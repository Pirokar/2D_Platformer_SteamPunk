var targetToLookAt : Transform;
var rotationSpeed : int = 1;
var bullet : GameObject;
var delayedTime;

function Update () {
	if(targetToLookAt) {
		var rotate = Quaternion.LookRotation(targetToLookAt.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
		
		var delayTime : int = Time.time;
		var delay = (delayTime/2);
		if(delay) {
			Fire(delayTime);
		}
	}
}

function Fire(delayTime) {
	if(delayTime!=delayedTime) {
		var bullet = Instantiate(bullet, transform.Find("BulletSpawn").transform.position, Quaternion.identity);
		bullet.rigidbody.AddForce(transform.forward*500);	
		delayedTime = delayTime;
	}
}