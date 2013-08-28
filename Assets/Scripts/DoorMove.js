static var open : boolean = false;
private var x : int = 0;
var MovingLength : int = 300;

function Update() {
	if(open) {
		if (x<=MovingLength) {
			transform.position +=(Vector3(0, 1, 0));
			x += 1;
		}
		else
			open = false;
	}
}