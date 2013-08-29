using UnityEngine; 
using System.Collections; 

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour { 
	public GameObject Player; 
	public Rigidbody ThisRigidpody; 
	public int speed = 5; 
	public int JumpSpeed = 8; 
	public bool Jumping;
	public bool pressed;
	float timeOfJump;
	public float AiTime;
	public bool isAiWait;
	
	void Start () {
		Player = (GameObject)this.gameObject; 
		ThisRigidpody = (Rigidbody)this.rigidbody;
		pressed = true;
		AiTime = Time.time;
		
	} 
	void Update(){
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
				pressed = true;
				GetComponentInChildren<OTAnimatingSprite>()._flipHorizontal = false;
				GetComponentInChildren<OTAnimatingSprite>().animationFrameset = "move";
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			Player.transform.position += Player.transform.right * speed * Time.deltaTime;
		} 
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			pressed = true;
			GetComponentInChildren<OTAnimatingSprite>()._flipHorizontal = true;
			GetComponentInChildren<OTAnimatingSprite>().animationFrameset = "move";
		}
	  	if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { 
			Player.transform.position -= Player.transform.right * speed * Time.deltaTime;
		} 
	 	if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) {
			pressed = true;
			GetComponentInChildren<OTAnimatingSprite>().animationFrameset = "move";
			if (Jumping == false) { 
				Jumping = true; 
	 			ThisRigidpody.AddForce(Player.transform.up * JumpSpeed, ForceMode.Impulse);
	 		} 
	  	}
		if(Input.anyKey == false && pressed && !isAiWait) {
			GetComponentInChildren<OTAnimatingSprite>().animationFrameset = "run";
			pressed = false;
		}
	
		if(Losing_Steams.damaged == true) {
			isAiWait = true;
			AiTime = Time.time;
			GetComponentInChildren<OTAnimatingSprite>().animationFrameset = "ai";
			
		}
	}
		
	void OnCollisionEnter(Collision collis) {
		if (collis.gameObject) { 
			Jumping = false; 
		} 
	} 
}