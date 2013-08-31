using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {
	
	public GameObject buttonExit;
	
	private OTAnimatingSprite _mySprite;
	public OTAnimatingSprite MySprite {
		get{
			if (_mySprite == null) {
				_mySprite = GetComponentInChildren<OTAnimatingSprite>();
			}
			return _mySprite;
		}
	}
	
	void Update () {
		
		if(OT.Over(buttonExit)) {
			MySprite.frameIndex = 1;
		}
		else
			MySprite.frameIndex = 0;
		
		if(OT.Clicked(buttonExit)) {
			MySprite.frameIndex = 2;
			Application.Quit();
		}
	}
}
