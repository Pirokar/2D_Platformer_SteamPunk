var emptySlot: Transform;
var xtemp;
var ytemp;
function OnMouseUp(){
	if (Vector3.Distance(transform.position,emptySlot.position)==1){
		xtemp=transform.position.x;
		ytemp=transform.position.y;
		transform.position.x=emptySlot.position.x;
		transform.position.y=emptySlot.position.y;
		emptySlot.position.x=xtemp;
		emptySlot.position.y=ytemp;
	}
}