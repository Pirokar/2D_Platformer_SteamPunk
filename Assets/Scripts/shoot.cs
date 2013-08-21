using UnityEngine; 
using System.Collections; 

public class Shoot : MonoBehaviour { 
public float Range = 1000 ; 
public float coolDown; 
public float attackTimer; 

void Update () { 
if(attackTimer > 0) 
attackTimer -= Time.deltaTime; 
if(attackTimer < 0) 
attackTimer = 0; 
if(attackTimer == 0 ){ 
if(Input.GetKeyDown(KeyCode.Z)){ 
Atack(); 
attackTimer = coolDown; 
} 
} 
} 
void Atack(){ 
Vector3 DirectionRay = transform.TransformDirection(Vector3.forward); 
RaycastHit Hit; 
if(Physics.Raycast(transform.position, DirectionRay,out Hit ,Range)){ 
if(Hit.collider.tag == "Enemy" ){ 
Destroy(Hit.collider.gameObject); 
} 
} 
} 
} 