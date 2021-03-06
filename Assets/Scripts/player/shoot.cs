﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 500;
    public float yValue = 1f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.2f; // Same as above

                                // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= coolDown)
        {
            if (Input.GetMouseButton(0))
            {
                Fire();
            }
        }
    }
    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x + xValue, transform.position.y + yValue, transform.position.z), transform.rotation) as Rigidbody2D;
        bPrefab.transform.localScale = transform.localScale / 10;
        bPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
        //Debug.Log(transform.right);
        coolDown = Time.time + attackSpeed;
        
        
      
    }
   
   
}

