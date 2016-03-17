using UnityEngine;
using System.Collections;


public class container_square : MonoBehaviour {


		public GameObject container;
		private BoxCollider boxCollider;//collider isn't used for collision detection, just for checking bounds for the shapes placed

		//locations of the 2 corners in world coordinates
		private Vector2 topLeft;
		private Vector2 bottomRight;
	// Use this for initialization
	void Start () {
				boxCollider = container.GetComponent<BoxCollider>();
				//Vector3 colliderSize =  (boxCollider.size); //vector3

				Vector3 worldCenter = transform.TransformPoint ( boxCollider.center );//transform center of collider to world coordinates
				//print(colliderSize);
				//print (container.GetComponent<Collider>().bounds.size);

				topLeft.x = worldCenter.x - (0.5f * container.GetComponent<Collider> ().bounds.size.x);
				topLeft.y = worldCenter.y - (0.5f * container.GetComponent<Collider> ().bounds.size.y);

				bottomRight.x = worldCenter.x + (0.5f * container.GetComponent<Collider> ().bounds.size.x);
				bottomRight.y = worldCenter.y + (0.5f * container.GetComponent<Collider> ().bounds.size.y);
				//we want to identify the top left and top right world coordinates
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void checkContainedShapes(){
				Collider2D[] result = Physics2D.OverlapAreaAll(topLeft,bottomRight);
				if (result != null) {
						//print (result.GetComponent<Moveable>().getContained() + " bounds");
						int resultSize = result.Length;
						foreach (Collider2D c in result) {
								c.GetComponent<Moveable> ().setContains (true);
						}
				}		
	}

}
