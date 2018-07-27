using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour {

    public float fireTime = .05f;
    public GameObject bulletPrefab;
    public float offset = 90f;
    

    public int pooledAmount = 20;
    List<GameObject> bullets;


	// Use this for initialization
	void Start () {
        bullets = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(bulletPrefab);
            obj.SetActive(false);
            bullets.Add(obj); 
        }
        Debug.Log(bullets);
        
	}

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("Fire", fireTime, fireTime);
        }
    }


    void Fire () {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = transform.position;
                Quaternion newRotation = Quaternion.AngleAxis(offset, transform.position);
                bullets[i].transform.rotation = newRotation;
                bullets[i].SetActive(true);
                break;
            }
        }
	}
}
