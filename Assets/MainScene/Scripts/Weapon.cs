using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
	public GameObject projectilePrefab;
	public GameObject upProjectilePrefab;
	public float fireRate;
	private float lastShotTime;
	public static int ammo = 30;
	public AudioClip gunfire;
	public static int steamsToUpgrade = 30;
	public OTAnimatingSprite playerSprite;
	public float offset = 500f;
	
	void Awake () {
		ammo = 30;
	}
	
	void Update () {
		if(Input.GetButton ("Fire1")) {
			if(ammo > 0)
				Fire ();
			else 
				return;
		}
	}
	
	void Fire () {
		if (lastShotTime + fireRate < Time.time) {
			lastShotTime = Time.time;
			audio.PlayOneShot (gunfire);
			GameObject shot;
			if (SteamSystem.currentSteams >= steamsToUpgrade) {
				shot = Instantiate (upProjectilePrefab, transform.position + new Vector3 (offset * (playerSprite._flipHorizontal ? -1f : 1f), 0f, 0f), Quaternion.identity) as GameObject;
			} else {
				shot = Instantiate (projectilePrefab, transform.position + new Vector3 (offset * (playerSprite._flipHorizontal ? -1f : 1f), 0f, 0f), Quaternion.identity) as GameObject;
			}
			
			shot.rigidbody.AddForce (transform.forward * 50000 * (playerSprite._flipHorizontal ? -1f : 1f));
			ammo--;
		}
	}
}
