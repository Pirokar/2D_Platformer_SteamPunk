var x = 0;
var a = 1;
var pause :boolean = false;
function Update () {
	if(Time.timeScale!=0) {
		if (x<=100) {
			transform.position = transform.position + a*(new Vector3 (0, 0.05, 0));
			x = x + a*1;
		}
		if (x==100||x==0)
			a*=-1;
		}
}
