static var weaponStrength : int = 3;
static var elementalStrength : int = 3;
static var elementFire = "Fire: ";
static var elementIce = "Ice: ";
static var elementLightning = "Lightning: ";

static var weaponFireRate : float = 0.3;

static var levelModifier : float = 1.1;
static var experience : int = 125;
static var experienceLimit = 150;
static var level : int = 1;
static var levelUp : boolean = false;
static var inven : boolean = false;

static var bool : boolean = false;

function Update() {
	if(experience >= experienceLimit) {
		levelUp = true;
		level++;
	}	
}