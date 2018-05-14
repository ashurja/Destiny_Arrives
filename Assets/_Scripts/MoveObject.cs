// Jamshed Ashurov 
// 05/03/2018
// This script is used to move the objects(ship for now).

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	//Distance between the two positions
	private float f_touch_delta;
	//End-Touch-Position
	private Vector2 v2_current_Position;
	//Start-Touch-Position
	private Vector2 v2_previous_Position;
	//How much movement is a swipe?
	public float i_comfort;
	//Speed of the player
	public float speed;
	//direction to move
	Vector3 direction= Vector3.left;



	void Update () {
		transform.Translate(direction * speed * Time.deltaTime);

		if (Input.touchCount == 1) {
			if (Input.GetTouch(0).phase == TouchPhase.Began){
				v2_previous_Position = Input.GetTouch(0).position;

			}
			if (Input.GetTouch(0).phase == TouchPhase.Ended){

				v2_current_Position = Input.GetTouch (0).position;
				f_touch_delta = (v2_current_Position.magnitude - v2_previous_Position.magnitude)*Time.deltaTime;


				// The code lines above are used to calculate the distance of the swipe the player makes 

				if (Mathf.Abs (f_touch_delta) > i_comfort){
					if(f_touch_delta > 0){
						if ((v2_current_Position.x - v2_previous_Position.x) > (v2_current_Position.y - v2_previous_Position.y)){
							Debug.Log ("Left");
							transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y+90, transform.rotation.z));

						}

					}
					else {
						if ((v2_current_Position.x - v2_previous_Position.x) < (v2_current_Position.y - v2_previous_Position.y)){
							transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y-90, transform.rotation.z));
							Debug.Log ("Right");


							// The lines of code above are used to determine whether the user swipes left or right. If the player swipes to the left, the ship will turn left
							// If the player swipes right, the ship will turn right 
						}

					}
				}

			}
		}
	}
}

