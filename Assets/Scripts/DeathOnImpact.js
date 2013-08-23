var player : GameObject;

function OnTriggerEnter (hit : Collider) {
	Destroy(player.gameObject);
	Application.LoadLevel("main_scene");
}