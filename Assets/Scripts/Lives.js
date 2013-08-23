var maxLives : int = 99;
var currentLives : int = 5;

function Update () {
}
function OnGUI() {
	if(currentLives >= 0) {
		GUI.Box(Rect(Screen.width - 151,0,50,50),"Lives");
		GUI.Label(Rect(Screen.width - 151,10,50,20),"Lives:"+currentLives);
	}
}