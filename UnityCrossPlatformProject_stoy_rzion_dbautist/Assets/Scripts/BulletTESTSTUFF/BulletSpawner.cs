using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    // Time interval for spawning
    private float timeCount = 0f;
    private int spawnCount = 0;
    public int spawnInterval = 4;
    public float timeInterval = 2f;

	public GameObject m_bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        timeCount += Time.deltaTime;

		if (timeCount >= timeInterval) {
            Instantiate(m_bullet, this.transform.position, this.transform.rotation);
            spawnCount++;
            if (spawnCount > spawnInterval){
                timeCount = 0f;
                spawnCount = 0;
            }
		}
	}
}
