using UnityEngine;
using System.Collections;

public class PipePuzzle : MonoBehaviour
{
	public PipePuzzleBlock prefab;
	public GameObject startBlockPrefab;
	public GameObject endBlockPrefab;
	public Material straightMat;
	public Material cornerMat;
	public Material crossMat;
	public PipePuzzleBlock[] blocks;
	private Transform pipesParent;
	private int start, end;
	public int size;
	public bool[] water;
	
	#region Singletone
	private static PipePuzzle _instance;

	public static PipePuzzle Instance {
		get {
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType (typeof(PipePuzzle)) as PipePuzzle;
			}
			return _instance;
		}
	}
	#endregion

	// Use this for initialization
	void Start ()
	{
		GeneratePuzzle (8);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void GeneratePuzzle (int fieldSize)
	{
		size = fieldSize;
		// Preparings
		pipesParent = (new GameObject ("_pipes")).transform;
		blocks = new PipePuzzleBlock[size * size];
		water = new bool[size * size];
		
		//Start/end
		start = Random.Range (0, size);
		end = Random.Range (0, size);
		GameObject startBlock = Instantiate (startBlockPrefab) as GameObject;
		GameObject endBlock = Instantiate (endBlockPrefab) as GameObject;
		startBlock.transform.parent = pipesParent;
		endBlock.transform.parent = pipesParent;
		startBlock.transform.position = new Vector3 (start, size + 1, 0f);
		endBlock.transform.position = new Vector3 (end, 0, 0f);
		
		// Create Objects
		for (int j = 0; j < size; j++) {
			for (int i = 0; i < size; i++) {
				int index = j * size + i;
				blocks [index] = (Instantiate (prefab.gameObject) as GameObject).GetComponent<PipePuzzleBlock> ();
				blocks [index].transform.parent = pipesParent;
				blocks [index].name = "Block_" + i + "_" + j;
				blocks [index].myI = i;
				blocks [index].myJ = j;
				blocks [index].transform.position = new Vector3 (i, size - j, 0f);
				blocks [index].MyType = (Random.value < 0.3f) ? (Random.value > 0.5f ? PipeType.Corner : PipeType.Cross) : PipeType.Straight;
			}
		}
		
		// Generate types
		
		// Center to camera
		pipesParent.transform.position = new Vector3 (-size * 0.5f, -size * 0.5f, 0f);
	}
	
	public bool Check ()
	{
		for (int i = 0; i < blocks.Length; i++) {
			blocks [i].renderer.material.color = Color.white;

		}
		
		water = new bool[size * size];
		FillPipeRecursively (blocks [start]);
		if (water [size * (size - 1) + end]) {
			Debug.Log ("WIN!!!");
		}
		return water [size * (size - 1) + end];
	}
	
	public void FillPipeRecursively (PipePuzzleBlock block)
	{
		int i = block.myI;
		int j = block.myJ;
		
		int index = j * size + i;
		water [index] = true;
		block.renderer.material.color = Color.blue;
		
		FillSafely (block, Side.Up, Side.Bottom, (j - 1) * size + i);
		FillSafely (block, Side.Bottom, Side.Up, (j + 1) * size + i);
		FillSafely (block, Side.Right, Side.Left, j * size + i + 1);
		FillSafely (block, Side.Left, Side.Right, j * size + i - 1);
	}
	
	public void FillSafely (PipePuzzleBlock block, Side side, Side neighbourSide, int neighbourBlockIndex)
	{
		if (block.IsSideAccessible (side)) {
			PipePuzzleBlock neighbourBlock = blocks [neighbourBlockIndex];
			if (!water [neighbourBlockIndex]) {
				if (neighbourBlock.IsSideAccessible (neighbourSide)) {
					FillPipeRecursively (neighbourBlock);
				}
			}
		}
	}
}
