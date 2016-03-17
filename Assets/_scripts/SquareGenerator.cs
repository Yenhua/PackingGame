using UnityEngine;
using System.Collections;

public class SquareGenerator : MonoBehaviour {
	
		Vector3 spawnPosition;
	
	// Use this for initialization
	void Start () {
				spawnPosition = new Vector3 (-5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
				GameObject.Instantiate(Resources.Load("ShapeSquare"),spawnPosition, Quaternion.identity); 
	}
}
