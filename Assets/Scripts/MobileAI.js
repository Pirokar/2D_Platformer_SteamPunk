static var x : float = 0;
static var a : int = 1;
var MovingLength : int;
var Health : float = 5;

function Update () {
	if(EnemyFire.isFire == false){
		transform.rotation = Quaternion.identity;
		if (x<=MovingLength) {
			transform.position += a*(Vector3 (1, 0, 0));
			x = x + a*1;
		}
		if (x==MovingLength||x==0)
			a*=-1;
	}
}
