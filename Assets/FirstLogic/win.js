var scene : GameObject;
var tile1: Transform;
var tile2: Transform;
var tile3: Transform;
var tile4: Transform;
var tile5: Transform;
var tile6: Transform;
var tile7: Transform;
var testcube: Transform;

private var p1: Vector3 = Vector3(0,0,0);
private var p2: Vector3 = Vector3(0,1,0);
private var p3: Vector3 = Vector3(1,1,0);
private var p4: Vector3 = Vector3(1,2,0);
private var p5: Vector3 = Vector3(2,2,0);
private var p6: Vector3 = Vector3(2,3,0);
private var p7: Vector3 = Vector3(3,3,0);

function Update () {
	if ((tile1.position==p1||tile1.position==p2||tile1.position==p3||tile1.position==p4||tile1.position==p5||tile1.position==p6||tile1.position==p7)&&
	(tile2.position==p1||tile2.position==p2||tile2.position==p3||tile2.position==p4||tile2.position==p5||tile2.position==p6||tile2.position==p7)&&
	(tile3.position==p1||tile3.position==p2||tile3.position==p3||tile3.position==p4||tile3.position==p5||tile3.position==p6||tile3.position==p7)&&
	(tile4.position==p1||tile4.position==p2||tile4.position==p3||tile4.position==p4||tile4.position==p5||tile4.position==p6||tile4.position==p7)&&
	(tile5.position==p1||tile5.position==p2||tile5.position==p3||tile5.position==p4||tile5.position==p5||tile5.position==p6||tile5.position==p7)&&
	(tile6.position==p1||tile6.position==p2||tile6.position==p3||tile6.position==p4||tile6.position==p5||tile6.position==p6||tile6.position==p7)&&
	(tile7.position==p1||tile7.position==p2||tile7.position==p3||tile7.position==p4||tile7.position==p5||tile7.position==p6||tile7.position==p7)) {
		Destroy(scene);
		Time.timeScale = 1;
		EnteringZone.isBack = true;
		EnteringZone.done = true;
		SteamSystem.currentSteams -= EnteringZone.steamsToOpen;
		DoorMove.open = true;
		
	}
}

function OnGUI() {
	if(GUI.Button(Rect(30,Screen.height - 100, 100, 50),"Назад")) {
		Time.timeScale = 1;
		EnteringZone.isBack = true;
		Destroy(scene);
	}
}