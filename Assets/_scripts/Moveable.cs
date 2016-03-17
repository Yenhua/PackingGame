using UnityEngine;
using System.Collections;


public class Moveable : MonoBehaviour {


	private Vector3 screenPoint;
	private Vector3 offset;
	private bool isContained;
	private bool isBounded;
		private float speed = 30f;
	
	void Start(){
		isContained = false;
		isBounded = false;
	}

	void Update(){

	}
	
	void OnMouseDown() {
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

		public bool getContained(){
				if (isBounded) {
						return false;
				}
				return isContained;
		}

		public void setBound(bool b){
				isBounded = b;
		}
		public void setContains(bool c){
				isContained = c;
		}

}
