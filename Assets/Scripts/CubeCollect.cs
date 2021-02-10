using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollect : MonoBehaviour {

	private bool quit = false; 
	public GUIText guiInfo, guiTime; 

	// Use this for initialization
	void Start () {
		guiInfo.text = (""); 
	}
	
	// Update is called once per frame
	void Update () {
		if (quit && Input.GetKeyDown (KeyCode.Q)) { 
			Application.Quit (); 
		} //end if 
	} //end Update 

	void OnTriggerEnter (Collider other) { 
		if (other.gameObject.CompareTag ("Collectible")) { 
			other.gameObject.SetActive (false); 
			guiInfo.text = ("Your Time: " + guiTime.text + "\nPress Q to Quit"); 
			quit = true; 
		} //end if 
	} //end OnTriggerEnter 

} //eof 
