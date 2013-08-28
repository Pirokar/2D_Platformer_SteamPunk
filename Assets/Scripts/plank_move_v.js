var MovingLength : int = 200;
static var x : int;
static var a : int;

function Start() {
	x = 0;
	a = 1;
}

function Update () {
	if(Time.timeScale!=0) {
		if (x<=MovingLength) {
			transform.position += a*(Vector3 (0, 2, 0));
			x = x + a*1;
		}
		if (x==MovingLength||x==0)
			a*=-1;
	}
}

function OnTriggerStay(coll : Collider) {
	if(coll.tag == "Player") {
		coll.transform.position += a*(Vector3(0, 2.8, 0));
	}
}