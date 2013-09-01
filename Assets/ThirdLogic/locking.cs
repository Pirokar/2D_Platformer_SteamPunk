using UnityEngine;
using System.Collections;

public class locking : MonoBehaviour {
	
	public Transform em;
	public bool click;
	
	void Start () {
		click = false;
	}

	void OnMouseUp(){
			click = !click;
			if(!click) {
				em.transform.position = em.transform.position - new Vector3(1,0,0);
			Debug.Log(em.transform.position.x);
				transform.localScale += new Vector3(0.3f,0,0);
				transform.localScale += new Vector3(0,0,0.3f);
			}
			else {
				em.transform.position = em.transform.position + new Vector3(1,0,0);
			Debug.Log(em.transform.position.x);
				transform.localScale -= new Vector3(0.3f,0,0);
				transform.localScale -= new Vector3(0,0,0.3f);
			}
		
	}
}
