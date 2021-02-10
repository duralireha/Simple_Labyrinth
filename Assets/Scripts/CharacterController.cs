using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	float speed = 5.0f; 

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked; 


	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed; 
		float strafe = Input.GetAxis ("Horizontal") * speed; 
		translation *= Time.deltaTime; 
		strafe *= Time.deltaTime; 

		transform.Translate (strafe, 0, translation); 

		//get cursor back 
		if (Input.GetKeyDown ("escape")) { 
			Cursor.lockState = CursorLockMode.None; 
		} //end if 

		// reset player 
		if (Input.GetKeyDown (KeyCode.R)) { 
			print ("R"); 
			transform.position = new Vector3 (0.0f, 2.0f, 0.0f); 
			//transform.rotation = new Vector3 (0.0f, 90.0f, 0.0f); 
		} //end if 

	} //end Update 
} //eof 