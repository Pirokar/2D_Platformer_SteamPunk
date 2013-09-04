using UnityEngine;
using System.Collections;

public class Round : MonoBehaviour {
	
	void Start() {
		MySprite.Play();
	}
	
	private OTAnimatingSprite _mySprite;
	public OTAnimatingSprite MySprite {
		get{
			if (_mySprite == null) {
				_mySprite = GetComponentInChildren<OTAnimatingSprite>();
			}
			return _mySprite;
		}
	}

	void Update() {
		transform.Rotate(new Vector3(0,0,0.3f));
	}
}
