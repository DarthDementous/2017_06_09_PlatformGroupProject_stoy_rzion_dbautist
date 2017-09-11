using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHandler : MonoBehaviour {

	public float moveSpeed;			
	public float xTargetPos;		/*Position to move to on the x axis.*/
	public float yTargetPos;

	public iTween.EaseType horizontalMovementCurve;
	public iTween.LoopType horizontalAnimLoop;

	public iTween.EaseType verticalMovementCurve;
	public iTween.LoopType verticalAnimLoop;

	private Vector3 m_velocity;

    private bool m_moveRight = true;

	// Use this for initialization
	void Start () {
        ///// NOTE: iTween can only move one piece of an object's transform at a time due to Unity setting the object's X, Y and Z all at once

        //// Move down linearly
        //iTween.MoveTo(gameObject, iTween.Hash("y", yTargetPos, "easetype", verticalMovementCurve, "looptype", verticalAnimLoop, "speed", moveSpeed));
        
        //// Loop moving right (and left once reached xTargetPos)
        //iTween.MoveTo(gameObject, iTween.Hash("x", xTargetPos, "easeType", horizontalMovementCurve, "loopType", horizontalAnimLoop, "speed", moveSpeed));

    }
	
	// Update is called once per frame
	void Update () {
        /// Horizontal movement
        // Reached right target position, signal to move left
        if (transform.position.x >= xTargetPos) {
            m_moveRight = false;
        }
        // Reached left target position, signal to move right
        if (transform.position.x <= -xTargetPos) {
            m_moveRight = true;
        }

        if (m_moveRight) {
            m_velocity.x = moveSpeed * Time.deltaTime;
        }
        else {
            m_velocity.x = -moveSpeed * Time.deltaTime;
        }

        /// Vertical movement
        m_velocity.y = -(moveSpeed * 0.05f) * Time.deltaTime;       // Move down with percentile of regular force

        // Update object position with calculated movement vector
        transform.position += m_velocity;
    }
}
