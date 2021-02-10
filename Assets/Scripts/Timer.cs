using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public GUIText timeDisplay; 
	private float playedTime; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playedTime += Time.deltaTime; 
		timeDisplay.text = ("Time: " + playedTime.ToString ("0.0")); 
	} //end Update 
}
