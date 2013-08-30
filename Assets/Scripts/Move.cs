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
	
	private OTAnimatingSprite _mySprite;
	public OTAnimatingSprite MySprite {
		get{
			if (_mySprite == null) {
				_mySprite = GetComponentInChildren<OTAnimatingSprite>();
			}
			return _mySprite;
		}
	}
	
	void Start () {
		Player = (GameObject)this.gameObject; 
		ThisRigidpody = (Rigidbody)this.rigidbody;
		pressed = true;
		MySprite.onAnimationFinish = OnAnimationFinished;
		
	} 
	
	public void OnAnimationFinished (OTObject owner){
		if (MySprite.animationFrameset == "ai") {
			MySprite.looping = true;
			MySprite.animationFrameset = "run";
			Debug.Log ("1");
			MySprite.Play ();
		}
	}
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
				pressed = true;
				MySprite._flipHorizontal = false;
				if(MySprite.looping)
					MySprite.animationFrameset = "move";
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			Player.transform.position += Player.transform.right * speed * Time.deltaTime;
		} 
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			pressed = true;
			MySprite._flipHorizontal = true;
			if(MySprite.looping)
				MySprite.animationFrameset = "move";
		}
	  	if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { 
			Player.transform.position -= Player.transform.right * speed * Time.deltaTime;
		} 
	 	if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow)) {
			pressed = true;
			if(MySprite.looping)
				MySprite.animationFrameset = "move";
			if (Jumping == false) { 
				Jumping = true; 
	 			ThisRigidpody.AddForce(Player.transform.up * JumpSpeed, ForceMode.Impulse);
	 		} 
	  	}
		if(Input.anyKey == false && pressed) {
			if(MySprite.looping)
				MySprite.animationFrameset = "run";
			pressed = false;
		}
	
		if(LosingSteams.damageAnim == true) {
			MySprite.looping = false;
			MySprite.animationFrameset = "ai";
			MySprite.numberOfPlays = 10;
			LosingSteams.damageAnim = false;

		}
	}
		
	void OnCollisionEnter(Collision collis) {
		if (collis.gameObject) { 
			Jumping = false; 
		} 
	} 
}