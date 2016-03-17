using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	
		public container_square container;//might want a more general way of implementing this for different shapded containers
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// check which shapes/objects are contained correctly
	public void checkContainment(){
				print ("checking shapes in container...");

				//
				GameObject[] allBounds ;
				allBounds = GameObject.FindGameObjectsWithTag("bound");
				foreach(GameObject b in allBounds) {
						b.GetComponent<BoundDetector> ().checkBounds ();
				}
						
				container.checkContainedShapes ();

				GameObject[] allShapes ;
				allShapes = GameObject.FindGameObjectsWithTag("shape");
				foreach(GameObject s in allShapes) {
						bool temp = s.GetComponent<Moveable>().getContained();
						print (temp);
				}
	}
}
