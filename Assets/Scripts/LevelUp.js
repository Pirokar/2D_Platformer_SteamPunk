var levelUpText = ("Leveled Up!");

function Update () {
	if(WeaponUpgrade.experience == WeaponUpgrade.experienceLimit) {
		WeaponUpgrade.levelUp = true;
		WeaponUpgrade.level++;
	}
}