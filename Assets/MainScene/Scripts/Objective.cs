using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour {
	public bool objectiveCompleted;
	public bool task;
	public float time;
	
	void Start() {
		task = true;
		objectiveCompleted = false;
		time = Time.time;
	}
	
	void Update() {
		if(Time.time - time > 4f)
			task = false;
	}
	
	void OnTriggerEnter(Collider player) {
		if(player.tag == "Player") {
			Time.timeScale = 0;
			objectiveCompleted = true;
			renderer.enabled = false;
		}
	}
	
	void OnGUI() {
		if(objectiveCompleted) {
			GUI.Box (new Rect(Screen.width/2 - 100,Screen.height/2 - 100, 200, 50),"");
			GUI.Label (new Rect(Screen.width/2 - 95,Screen.height/2 - 90, 190, 40),"Поздравляем, вы прошли игру!");
			if(GUI.Button(new Rect(Screen.width/2 - 95,Screen.height/2, 190, 40),"В меню")) {
				Application.LoadLevel("MainMenu");
			}
		}
		if(task) {
			GUI.Box (new Rect(Screen.width/2 - 100,Screen.height/2 - 25, 200, 80),"");
			GUI.Label (new Rect(Screen.width/2 - 80,Screen.height/2 - 15, 100, 70),"Добраться до энергетического кристалла");
		}
		
			
	}
}
