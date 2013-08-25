var MovingLength = 100;
static var x = 0;
static var a = 1;
static var pause :boolean = false;
function Update () {
	if(Time.timeScale!=0) {
		if (x<=MovingLength) {
			transform.position = transform.position + a*(new Vector3 (0, 0.05, 0.05));
			x = x + a*1;
		}
		if (x==MovingLength||x==0)
			a*=-1;
		}
}