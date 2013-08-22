var play : boolean = false;
var playTex : Texture2D;
var options : boolean = false;
var optionsTex : Texture2D;
var quit : boolean = false;
var quitTex : Texture2D;

function Update () {

}

function OnGUI() {
	if(GUI.Button(Rect(Screen.width - 710,120,170,50),"Play")) {
		play = true;
		Application.LoadLevel("main_scene");
	}
	if(GUI.Button(Rect(Screen.width - 710,220,170,50),"Options")) {
		options = true;
		Application.LoadLevel("Options");
	}
	if(GUI.Button(Rect(Screen.width - 710,320,170,50),"Quit")) {
		quit = true;
		Application.Quit();
	}
}