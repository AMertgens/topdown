using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour {
	public float speed = 20;
    
    // Use this for initialization
    void Start () {
		
        

    }
	
	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis ("Horizontal");
		float axisY = Input.GetAxis ("Vertical");
        var rigibody = this.gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        rigibody.velocity = new Vector2(axisX * speed, axisY * speed);
       

    }

    
}
