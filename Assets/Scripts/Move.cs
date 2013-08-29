using UnityEngine; 
using System.Collections; 

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour { 
	public GameObject Player; 
	public Rigidbody ThisRigidpody; 
	public int speed = 5; 
	public int JumpSpeed = 8; 
	public bool Jumping; 
	public GameObject Anim;
	
	
	//_animationFrameset 
	void Start () {
		Player = (GameObject)this.gameObject; 
		ThisRigidpody = (Rigidbody)this.rigidbody; 
	} 
	void Update(){
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { 
			Player.transform.position += Player.transform.right * speed * Time.deltaTime;
			//gameObject.GetComponent(OTSprite)._flipHorizontal = false;
		} 
	  	if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { 
	 		Player.transform.position -= Player.transform.right * speed * Time.deltaTime;
			//gameObject.GetComponent(OTSprite)._flipHorizontal = true;
	  	} 
	 	if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) {
			//OTAnimatingSprite._animationFrameset = "run";
			
			if (Jumping == false) { 
				Jumping = true; 
				//OTAnimatingSprite._animationFrameset = "move";
	 			ThisRigidpody.AddForce(Player.transform.up * JumpSpeed, ForceMode.Impulse);
				
				
	 		} 
	  	}
	}
		
	void OnCollisionEnter(Collision collis) { 
		if (collis.gameObject) { 
			Jumping = false; 
		} 
	} 
}