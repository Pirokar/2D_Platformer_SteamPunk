using UnityEngine;
using System.Collections;

public class MobileAI : MonoBehaviour {
	
	public GameObject BulletSpawn;
	public static float x = 0;
	public static int a = 1;
	public int MovingLength;
	public static float Health = 5f;

	private OTAnimatingSprite _mySprite;
	public OTAnimatingSprite MySprite {
		get{
			if (_mySprite == null) {
				_mySprite = GetComponentInChildren<OTAnimatingSprite>();
			}
			return _mySprite;
		}
	}
	
	void Start() {
		x = 0;
		a = 1;
		Health = 5f;
	}
	
	void Update () {
		if(EnemyFire.isFire == false && Time.timeScale == 1){
			if (x <= MovingLength) {
				transform.position += a*(new Vector3 (1, 0, 0));
				x = x + a*1;
			}
			if (x==MovingLength||x==0) {
				a*=-1;
				MySprite._flipHorizontal = !MySprite._flipHorizontal;
			}
				
		}
	}
}