#pragma strict
var l1: Transform;
var l2: Transform;
var l3: Transform;
var l4: Transform;
var l5: Transform;

function Start () {

}

function Update () {
	if (l1.transform.localScale.z<1 && l2.transform.localScale.z<1 && l3.transform.localScale.z<1 && l4.transform.localScale.z<1 && l5.transform.localScale.z<1){
		Debug.Log("You Win");
	}

}