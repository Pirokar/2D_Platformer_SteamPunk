//var startPosition = this.transform.position;
var MovingLength : int = 100;
var tempLives : int = Lives.currentLives;
static var x : int = 0;
static var a : int = 1;
static var pause : boolean = false;

function Update () {
	if(Time.timeScale!=0) {
		if (x<=MovingLength) {
			transform.position += a*(new Vector3 (0, 0.05, 0));
			x = x + a*1;
		}
		if (x==MovingLength||x==0)
			a*=-1;
		}
	if(tempLives>Lives.currentLives) {
		tempLives--;
		//transform.position = startPosition;
	}
}
