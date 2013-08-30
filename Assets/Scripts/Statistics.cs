using UnityEngine;
using System.Collections;

public class Statistics : MonoBehaviour {

	void OnGUI() {
		if(SteamSystem.more==false && Lives.currentLives >= 0) {
			GUI.Box(new Rect(Screen.width - 150,0,150,80),"");
			GUI.Label(new Rect(Screen.width - 150,-3,130,20),"Пули:"+Weapon.ammo);
			GUI.Label(new Rect(Screen.width - 150,20,130,20),"Шестеренки: "+ SteamSystem.currentSteams);
			GUI.Box(new Rect(0,0,70,50),"Жизни");
			GUI.Label(new Rect(6,20,70,20),"Жизни: "+Lives.currentLives);
		}
	}
}