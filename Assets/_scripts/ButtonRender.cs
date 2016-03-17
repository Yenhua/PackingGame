using UnityEngine;
using System.Collections;

public class ButtonRender : MonoBehaviour {


		public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnGUI()
		{
			if (GUI.Button (new Rect (0, 0, 180, 20), "Check collisions")) {
						print ("checking collisions clicked");
						gameController.checkContainment ();
			}
		}
}
