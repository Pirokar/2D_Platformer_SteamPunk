var myMeshRenderer:MeshRenderer;
var RenderMesh:boolean = false;
var renderTime : float;
var renderRate : float = 0.3;
var togglePause : float;

function Awake() {
	togglePause = Time.time + 3.0;
}
function Update() {
	
	if (Time.time > renderTime + togglePause){
		RenderMesh=!RenderMesh;
		renderTime = Time.time + renderRate;
		this.togglePause = 0.0;
	}
	if(RenderMesh) {
		myMeshRenderer.enabled = true;
		gameObject.GetComponent("Halo").enabled = true;
	}
	if(!RenderMesh) {
		myMeshRenderer.enabled = false;
		gameObject.GetComponent("Halo").enabled = false;
	}
}