using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHandler : MonoBehaviour {

	public float moveSpeed;			
	public float xTargetPos;		/*Position to move to on the x axis.*/

	public iTween.EaseType movementCurve;
	public iTween.LoopType animLoop;

	private float m_velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		iTween.MoveTo (gameObject, iTween.Hash ("x", xTargetPos, "easetype", movementCurve, "looptype", animLoop, "speed", moveSpeed));
	}
}
