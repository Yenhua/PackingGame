﻿using UnityEngine;
using System.Collections;


public class Moveable : MonoBehaviour {


	private Vector3 screenPoint;
	private Vector3 offset;
	private bool isContained;
	private bool isBounded;
	private float speed = 30f;
	private float rotationSpeed = 90f;
	
	void Start(){
		isContained = false;
		isBounded = false;
	}

	void Update(){
		//raycast so we dont rotate every object
		if (Input.GetMouseButton(0) && Input.GetKey (KeyCode.A)){
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit.collider != null){
				hit.collider.gameObject.transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
				//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
			}
		}
		if (Input.GetMouseButton(0) && Input.GetKey (KeyCode.D)){
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit.collider != null){
				hit.collider.gameObject.transform.Rotate(0,0, -(rotationSpeed * Time.deltaTime));
				//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
			}
		}


		//if (Input.GetMouseButton (0) && Input.GetKey (KeyCode.A) ) { 
		//	gameObject.transform.Rotate(0,0, rotationSpeed * Time.deltaTime);//anti-clockwise
		//}
		//if (Input.GetMouseButton (0) && Input.GetKey (KeyCode.D) ) { 
		//	gameObject.transform.Rotate(0,0, -(rotationSpeed * Time.deltaTime));//clockwise
		//}
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
