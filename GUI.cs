using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour {

	public GameObject pre_cube,priest,devil,boat;
	// Use this for initialization
	void OnGUI() {
		if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
			print("You clicked the button!");

	}
	void Start () {
		Instantiate (pre_cube, new Vector3 (-8, 0, 0), Quaternion.identity);
		Instantiate (pre_cube, new Vector3 (8, 0, 0), Quaternion.identity);
		Instantiate (boat, new Vector3 (2, -1, 0), Quaternion.identity);
		Instantiate (priest, new Vector3 (10, 1, 0), Quaternion.identity);
		Instantiate (priest, new Vector3 (9, 1, 0), Quaternion.identity);
		Instantiate (priest, new Vector3 (8, 1, 0), Quaternion.identity);
		Instantiate (devil, new Vector3 (7, 1, 0), Quaternion.identity);
		Instantiate (devil, new Vector3 (6, 1, 0), Quaternion.identity);
		Instantiate (devil, new Vector3 (5, 1, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
