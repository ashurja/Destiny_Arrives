using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMover : MonoBehaviour {

	public float speed;
	//direction to move
	Vector3 direction= Vector3.left;



	void Update () {
		transform.Translate (direction * speed * Time.deltaTime);
	}
}
