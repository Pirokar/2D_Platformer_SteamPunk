var click : boolean = false;

function OnMouseUp(){
	click = !click;
	if(!click) {
		transform.localScale.x=1;
		transform.localScale.z=1;
	}
	else {
		transform.localScale.x=0.75;
		transform.localScale.z=0.75;
	}
}