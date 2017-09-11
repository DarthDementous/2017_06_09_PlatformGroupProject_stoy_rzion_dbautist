using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

    public int      wave1Count;
    public float    enemySpacing;

	// Use this for initialization
	void Start () {
        /// First wave
        float currentSpacing = enemySpacing / wave1Count; 

        for (int i = 0; i < wave1Count; ++i) {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
