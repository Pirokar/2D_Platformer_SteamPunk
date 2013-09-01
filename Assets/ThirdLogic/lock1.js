var click : boolean = false;
var em: Transform;
function OnMouseUp(){
	click = !click;
	if(!click) {
	 	em.transform.position.x=em.transform.position.x-1;
		transform.localScale.x=1;
		transform.localScale.z=1;
	}
	else {
		em.transform.position.x=em.transform.position.x+1;
		transform.localScale.x=0.75;
		transform.localScale.z=0.75;
	}
}