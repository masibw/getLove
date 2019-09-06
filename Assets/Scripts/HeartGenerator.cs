using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour {

    public GameObject heartPrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenHeart", 1, 1);
		
	}
	
	    void GenHeart()
    {
        Instantiate(heartPrefab, new Vector3(-10.5f + 30 * Random.value, 25, 0), Quaternion.identity);
    
		
	}
}
