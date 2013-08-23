var objective = "Find 50 Mushrooms!";
var objectiveComplete = "Found 50 Mushrooms!";
var objectiveCompleteBool : boolean = false;
var crystals : int = 0;

function OnTriggerEnter (crystal : Collider) {
	if(crystal.tag=="Player") {
		Debug.Log("Found 1 mushroom!");
		crystals++;	
	}
}
function Update() {
	if(crystals>=50) {
		objectiveCompleteBool = true;
	}
}

function OnGUI() {
	if(objectiveCompleteBool) {
		GUI.Box(Rect(200,250,175,125),"Bjorn");
		GUI.Label(Rect(200,275,125,125),"So now we can make mushrooms stew!");
		if(GUI.Button(Rect(200,375,125,25),"Make Stew?")) {
			Application.LoadLevel("Kitchen");
		}
	}
}