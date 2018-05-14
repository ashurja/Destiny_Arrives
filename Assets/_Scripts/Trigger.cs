// Jamshed Ashurov 
// 05/03/2018
// This code is used to determine the trigger collider and call the specific function 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Trigger : MonoBehaviour {
	
	public RandomSpawn rs; 

	// Use this for initialization
 	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene("Win");
		}
	}
			// If the collider detects Player, it will call the "SpawnTile" function from the other script. 
				//}
				//if (other.tag == "Route") {
				//return; 
				//}
}
