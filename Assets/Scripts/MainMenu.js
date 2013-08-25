var playTex : Texture2D;
var quitTex : Texture2D;

function OnGUI() {
	if(GUI.Button(Rect(Screen.width - 760,220,170,50),"Играть")) {
		Time.timeScale = 1;
		Application.LoadLevel("main_scene");
	}
	if(GUI.Button(Rect(Screen.width - 760,320,170,50),"Выйти")) {
		Application.Quit();
	}
}