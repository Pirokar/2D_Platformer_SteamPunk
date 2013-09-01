using UnityEngine;
using System.Collections;

public class PipePuzzleBlock : MonoBehaviour
{
	public PipeType type;

	public PipeType MyType {
		set {
			switch (value) {
			case PipeType.Straight:
				renderer.sharedMaterial = PipePuzzle.Instance.straightMat;
				break;
			case PipeType.Corner:
				renderer.sharedMaterial = PipePuzzle.Instance.cornerMat;
				break;
			case PipeType.Cross:
				renderer.sharedMaterial = PipePuzzle.Instance.crossMat;
				break;
			}
			type = value;
		}
		get {
			return type;
		}
	}
	
	public int myI, myJ;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
		transform.Rotate (Vector3.forward * 90);
//		win2.Instance.Check ();
		PipePuzzle.Instance.Check ();
		float angle = transform.rotation.eulerAngles.z;
	}
	
	public bool IsSideAccessible (Side side)
	{
		int fieldSize = PipePuzzle.Instance.size;
		switch (side) {
		case Side.Bottom:
			if (myJ == fieldSize - 1) {
				return false;
			}
			break;
		case Side.Left:
			if (myI == 0) {
				return false;
			}
			break;
		case Side.Right:
			if (myI == fieldSize - 1) {
				return false;
			}
			break;
		case Side.Up:
			if (myJ == 0) {
				return false;
			}
			break;
		}
		float angle;
		switch (MyType) {
		case PipeType.Straight:
			angle = Vector3.Angle (transform.up, Vector3.up);
			if (angle < 10 || angle > 170) {
				return side == Side.Up || side == Side.Bottom;
			} else {
				return side == Side.Right || side == Side.Left;
			}
			break;
		case PipeType.Corner:
			angle = transform.rotation.eulerAngles.z;
			if (angle < 10 || angle > 350) {
				return side == Side.Left || side == Side.Up;
			} else if (angle > 80 && angle < 100) {
				return side == Side.Right || side == Side.Up;
			} else if (angle > 170 && angle < 190) {
				return side == Side.Right || side == Side.Bottom;
			} else if (angle > 260 && angle < 280) {
				return side == Side.Left || side == Side.Bottom;
			}
			break;
		case PipeType.Cross:
			return true;
		}
		
		return false;
	}
}

public enum PipeType
{
	Straight,
	Corner,
	Cross
}

public enum Side
{
	Up = 0,
	Right = 90, 
	Bottom = 180,
	Left = 270
}