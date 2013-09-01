using UnityEngine;
using System.Collections;

public class locking : MonoBehaviour {
	
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject five;
	public GameObject six;
	public GameObject seven;
	public GameObject eight;
	public GameObject nine;
	public bool click;
	public locking locker;
	
	void Start () {
		click = false;
	}

	void OnMouseUp(){
//		if(<Line1>().clicked == false) {
//			<Line1>().clicked == true;
	//		if(one.GetComponent<locking>().click == true)
	//			one.GetComponent<locking>().click = false;
	//		if(two.GetComponent<locking>().click == true)
	//			two.GetComponent<locking>().click = false;
	//		if(three.GetComponent<locking>().click == true)
	//			three.GetComponent<locking>().click = false;
	//		if(four.GetComponent<locking>().click == true)
	//			four.GetComponent<locking>().click = false;
	//		if(five.GetComponent<locking>().click == true)
	//			five.GetComponent<locking>().click = false;
	//		if(six.GetComponent<locking>().click == true)
	//			six.GetComponent<locking>().click = false;
	//		if(seven.GetComponent<locking>().click == true)
	//			seven.GetComponent<locking>().click = false;
	//		if(eight.GetComponent<locking>().click == true)
	//			eight.GetComponent<locking>().click = false;
	//		if(nine.GetComponent<locking>().click == true)
	//			nine.GetComponent<locking>().click = false;
			click = !click;
			if(!click) {
				transform.localScale += new Vector3(0.3f,0,0);
				transform.localScale += new Vector3(0,0,0.3f);
			}
			else {
				transform.localScale -= new Vector3(0.3f,0,0);
				transform.localScale -= new Vector3(0,0,0.3f);
			}
		
	}
}
