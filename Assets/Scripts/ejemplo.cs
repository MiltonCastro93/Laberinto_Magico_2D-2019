using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemplo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.up = Vector3.zero - transform.position;
    }
}
