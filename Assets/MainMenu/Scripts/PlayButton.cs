using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	
	public GameObject buttonPlay;
	
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
		
		if(OT.Over(buttonPlay)) {
			MySprite.frameIndex = 1;
		}
		else
			MySprite.frameIndex = 0;
		
		if(OT.Clicked(buttonPlay)) {
			MySprite.frameIndex = 2;
			Time.timeScale = 1;
			Application.LoadLevel("MainScene");
		}
	}
}

