function OnMouseUp(){
		transform.Rotate(Vector3.forward*90);
		Debug.Log(transform.rotation);
		win2.Instance.Check ();
	}
