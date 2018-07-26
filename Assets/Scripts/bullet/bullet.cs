using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
