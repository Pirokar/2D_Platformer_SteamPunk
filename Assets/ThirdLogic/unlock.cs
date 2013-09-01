using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

	public GameObject scene;
	public Transform l1;
	public Transform l2;
	public Transform l3;
	public Transform l4;
	public Transform l5;
	public Transform em;
	
	void Start() {
		Debug.Log(em.position.x);
		em.transform.position = new Vector3(0f,0f,0f);
		Debug.Log(em.position.x);
	}

	void Update () {
		
		if (l1.transform.localScale.z<1 && 
		l2.transform.localScale.z<1 && 
		l3.transform.localScale.z<1 && 
		l4.transform.localScale.z<1 && 
		l5.transform.localScale.z<1&& 
		em.transform.position.x==5) {
				EnteringZone2.isBack = true;
				EnteringZone2.done = true;
				SteamSystem.currentSteams -= EnteringZone2.steamsToOpen;
				DoorMove2.open = true;
				Time.timeScale = 1;
				Destroy(scene);
		}
	}
	void OnGUI() {
		GUI.Box(new Rect(Screen.width/2,Screen.height/2,400,300),"");
		GUI.Label(new Rect(Screen.width/2 + 20, Screen.height/2+ 20, 400,300), "    Чтобы открыть дверь нужно расшифровать пароль. \n    По приведенному примеру можно догадаться каким образом шифруется каждая цифра. \n    Пример: Зашифрованный пароль:  69234 \n Расшифрованный пароль: 41876\n    Расшифруйте пароль и введите его с помощью кнопок.\n    Первая линия кнопок это первая цифра пароля (соответственно последняя цифра это последняя линия).\n    Дверь откроется после того будет введен весь пароль и не зажаты остальные кнопки.\n    Чтобы отжать кнопки нажмите на нее повторно\n    Удачи!");
	}
}
