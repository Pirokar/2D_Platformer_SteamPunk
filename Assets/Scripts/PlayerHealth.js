var maxHealth : int = 100;
static var currentHealth : int = 100;
var bool : boolean = false;

function Update () {
	if(currentHealth < 0) {
		currentHealth = 0;
	}
	if(currentHealth > maxHealth) {
		currentHealth = maxHealth;
	}
	if(maxHealth < 1) {
		maxHealth = 1;
	}
	if(currentHealth < 0) {
		Application.LoadLevel ("GameOver");
	}
}