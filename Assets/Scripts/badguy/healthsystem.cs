using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthsystem : MonoBehaviour {
    public float health = 10f;
    
   
	// Use this for initialization
	void Start () {
        
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger enter");
        if (other.CompareTag("bullet"))
        {   
            Debug.Log("hit");
            
            health -= 1;
            Debug.Log(health);
        }
    }
}
