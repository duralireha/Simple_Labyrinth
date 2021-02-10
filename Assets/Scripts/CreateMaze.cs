using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMaze : MonoBehaviour {

	public Transform floor, wall, ending; 
	private int[ , , ] maze; 
	private int mazeNum; 

	// Use this for initialization 

	void Start () { 
		maze = new int[ , , ] {{ 
			{1, 0, 1, 0, 1}, 
			{1, 0, 1, 1, 1}, 
			{1, 1, 1, 0, 1}, 
			{0, 0, 1, 0, 1}, 
			{1, 1, 1, 0, 1} }, 
		{ 
			{1, 1, 1, 0, 1}, 
			{0, 0, 1, 0, 1}, 
			{1, 0, 1, 1, 1}, 
			{1, 1, 1, 0, 0}, 
			{1, 0, 1, 1, 1} }, 
		{ 
			{1, 0, 0, 1, 0}, 
			{1, 1, 1, 1, 1}, 
			{0, 0, 1, 0, 1}, 
			{1, 1, 1, 0, 0}, 
			{1, 0, 1, 1, 1} }, 
		{ 
			{1, 0, 0, 1, 0}, 
			{1, 1, 1, 1, 1}, 
			{0, 1, 0, 0, 1}, 
			{1, 1, 1, 0, 0}, 
			{1, 0, 1, 1, 1} }, 
		{ 
			{1, 1, 1, 1, 0}, 
			{0, 1, 0, 1, 0}, 
			{1, 1, 0, 0, 0}, 
			{0, 1, 1, 1, 1}, 
			{0, 1, 0, 0, 1} }}; 
		
		// maze 
		mazeNum = Random.Range (0, 5); // returns a random value between min (incl) and max (excl) 

		for (int z = 0; z < 5; z++) { 
			for (int x = 0; x < 5; x++) { 
				if (maze [mazeNum, x, z] == 1) { 
					Instantiate (floor, new Vector3 (x * 5, 0, z * 5), Quaternion.identity); //floor 
					Instantiate (floor, new Vector3 (x * 5, 5, z * 5), Quaternion.identity); //ceiling 
				} else { 
					Instantiate (wall, new Vector3 (x * 5, 2.5f, z * 5), Quaternion.identity); //walls 
				} //end if else 
			} //end inner for 
		} //end outer for 

		print ("Maze Number: " + (mazeNum+1)); 

		// ending 
		Instantiate (ending, new Vector3 (20, 1.5f, 20), Quaternion.identity);

	} //end Start 
	
	// Update is called once per frame
	void Update () {
		
	} 

}
