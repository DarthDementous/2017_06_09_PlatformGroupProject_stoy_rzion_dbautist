using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {
	
	private Vector3 m_velocity;

	private float m_timer = 0;
	public float m_threshold = 5f;
	public float m_speed = 5;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		// Temporary calculation of movement downwards
		m_velocity = new Vector3 (0, -1, 0) * m_speed * Time.deltaTime;
		this.transform.position += m_velocity;

		m_timer += Time.deltaTime;
		// Temporary deletion statement (TODO: Collision deletion)
		if (m_timer >= m_threshold) {

			Destroy (this.gameObject);
		}
	}
}
