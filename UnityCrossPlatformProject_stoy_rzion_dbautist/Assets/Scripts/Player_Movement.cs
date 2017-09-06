using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public float initialSpeed;
	public float screenRange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x, move_dist, move_speed;
		 x = Input.GetAxis ("Horizontal");

		move_speed = ((initialSpeed + Time.deltaTime));
		move_dist = (Time.deltaTime * move_speed) * x;

		// move the player respectivley
		transform.Translate (move_dist, 0, 0);

		// restrict the player to between the screen bounds.
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -screenRange, screenRange), transform.position.y, 0);


	}
}
	