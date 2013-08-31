using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {

	public Transform targetToLookAt;
	public int rotationSpeed = 1;
	public float fireRate;
	private float lastShotTime;
	public bool isFire;
	public bool isisFire;
	public float delay;
	public GameObject bulletPrefab;
	public float offset = 5f;
	public OTAnimatingSprite playerSprite;
	
	void Start () {
		playerSprite._flipHorizontal = true;
	}
	
	void Update () {
		if(targetToLookAt && Vector3.Distance(targetToLookAt.position,transform.position) < 600 && (targetToLookAt.position.y - transform.position.y < 50 && transform.position.y - targetToLookAt.position.y < 50)) {
			if(!isisFire)
				isisFire = true;
			if(!isFire && targetToLookAt.position.x - transform.position.x < 0)
				if(playerSprite._flipHorizontal)
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
			if(!isFire && targetToLookAt.position.x - transform.position.x > 0)
				if(!playerSprite._flipHorizontal)
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
			if(!isFire)
				playerSprite.animationFrameset = "stay";
			if(targetToLookAt.position.x - transform.position.x < 0) {
				Quaternion rotate = Quaternion.LookRotation(transform.position - targetToLookAt.position);
				transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
			}
			if(targetToLookAt.position.x - transform.position.x > 0) {
				Quaternion rotate = Quaternion.LookRotation(transform.position - targetToLookAt.position);
				transform.rotation = Quaternion.Slerp(transform.rotation,rotate,Time.deltaTime + rotationSpeed);
			}
			float delayTime = Time.time;
			delay = (delayTime/2);
			if (lastShotTime + fireRate < Time.time) {
				Fire ();
			}
			isFire = true;
		}
		else {
			if(isisFire)
				isisFire = false;
			if (targetToLookAt.position.x - transform.position.x < 0) {
				
				if(isFire && !playerSprite._flipHorizontal && GameObject.Find ("Enemy0").GetComponent<MobileAI>().a>0) 
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
				if(isFire && playerSprite._flipHorizontal) {
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
					if(isFire && !playerSprite._flipHorizontal)
						playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
				}
			}
			else {
				
				if(isFire && playerSprite._flipHorizontal && GameObject.Find ("Enemy0").GetComponent<MobileAI>().a<0) 
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
				if(isFire && !playerSprite._flipHorizontal) {
					playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
					if(isFire && playerSprite._flipHorizontal)
						playerSprite._flipHorizontal = !playerSprite._flipHorizontal;
				}
			}
			if(isFire)
				playerSprite.animationFrameset = "run";
			isFire = false;
		}
	}	
	
	void Fire () {
		GameObject bullet;
		if(targetToLookAt.position.x - transform.position.x > 0) {
			bullet = Instantiate(bulletPrefab, transform.position + new Vector3(offset * (playerSprite._flipHorizontal ? 1f : -1f), 0f, 0f), Quaternion.identity) as GameObject;
			bullet.rigidbody.AddForce(transform.forward * 20000 * (playerSprite._flipHorizontal ? -1f : 1f));
		}
		else {
			bullet = Instantiate(bulletPrefab, transform.position + new Vector3(offset * (playerSprite._flipHorizontal ? 1f : -1f), 0f, 0f), Quaternion.identity) as GameObject;
			bullet.rigidbody.AddForce(transform.forward * 20000 * (playerSprite._flipHorizontal ? 1f : -1f));
		}
		lastShotTime = Time.time;
	}
}
