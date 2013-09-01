#pragma strict
var l1: Transform;
var l2: Transform;
var l3: Transform;
var l4: Transform;
var l5: Transform;
var em: Transform;
function Start () {
	em.transform.position.x=0;
}
//
function Update () {
	Debug.Log(em.transform.position.x);
	if (l1.transform.localScale.z<1 && l2.transform.localScale.z<1 && l3.transform.localScale.z<1 && l4.transform.localScale.z<1 && 
	l5.transform.localScale.z<1&& em.transform.position.x==5){
		Debug.Log("You Win");
	}

}