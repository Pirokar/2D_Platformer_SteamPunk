var playTex : Texture2D;
var quitTex : Texture2D;

function OnGUI() {
	if(GUI.Button(Rect(Screen.width - 760,120,298,123),playTex)) {
		Time.timeScale = 1;
		Application.LoadLevel("main_scene");
	}
	if(GUI.Button(Rect(Screen.width - 760,420,297,118),quitTex)) {
		Application.Quit();
	}
}