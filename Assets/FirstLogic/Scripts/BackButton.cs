using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {
	
	public GameObject buttonBack;
	public GameObject scene;
	
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
		
		if(OT.Over(buttonBack)) {
			MySprite.frameIndex = 1;
		}
		else
			MySprite.frameIndex = 0;
		
		if(OT.Clicked(buttonBack)) {
			MySprite.frameIndex = 2;
			Time.timeScale = 1;
			EnteringZone.isBack = true;
			Destroy(scene);
		}
	}
}