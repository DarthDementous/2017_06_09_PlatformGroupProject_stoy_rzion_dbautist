using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    // Time interval for spawning
    public float timeCount = 0f;
    public float timeInterval = 2f;

	public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeCount += Time.deltaTime;

		if (timeCount >= timeInterval) {
			Instantiate (Bullet, this.transform.position, this.transform.rotation);
			timeCount = 0f;
		}
	}
}
