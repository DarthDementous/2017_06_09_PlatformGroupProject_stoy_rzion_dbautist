using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {
	
	private Vector3 m_velocity;

	private float m_timer = 0;
    public float m_startupRocket = 5f;
	public float m_threshold = 5f;
	public float m_speed = 0.5f;

	// Use this for initialization
	private void Start () {
		
	}

	// Update is called once per frame
	private void Update () {


        if (m_timer >= m_startupRocket)
        {
            m_speed = 10f;
        }

		// Calculation of movement downwards
		m_velocity.y = -m_speed * Time.deltaTime;
		this.transform.position += m_velocity;
        
        m_timer += Time.deltaTime;  // temporary timer for deletion statement
		// Temporary deletion statement (TODO: Collision deletion)
		if (m_timer >= m_threshold) {Destroy (this.gameObject);}
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TopBorder" || collision.gameObject.tag == "BotBorder" || collision.gameObject.tag == "RightBorder" || collision.gameObject.tag == "LeftBorder")
        {
            Destroy(this.gameObject);
        }
    }
}
