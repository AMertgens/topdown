using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float speed = 5;
	// Use this for initialization
	void Start () {
        //Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("P layer").GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
