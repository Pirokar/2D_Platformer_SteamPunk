var back : boolean = false;

function OnGUI () {
	if(GUI.Button(Rect(Screen.width - 710,420,140,30),"Back")) {
		Application.LoadLevel("MainMenu");
	}
}