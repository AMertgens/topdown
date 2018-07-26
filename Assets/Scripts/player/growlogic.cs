using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growlogic : MonoBehaviour
{


    //private List<GameObject> badguylist;
    private List<Vector3> badposlist = new List<Vector3>();
    public float distance = 10.0f;
    public float growrate = 0.01f;
    public float growfactor = 1f;
    private float framecounter = 0.0f;
    public bool isinRange = false;
    public float shrinkrate = 0.5f;


    // Use this for initialization
    void Start()
    {
        List<GameObject> badguylist = new List<GameObject>();
        badguylist.AddRange(GameObject.FindGameObjectsWithTag("badguy"));
        foreach (GameObject b in badguylist)
        {

            badposlist.Add(b.transform.position);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
        checkRange();
        if (isinRange)
        {
            if (framecounter % 100 == 0)
            {
                // if player is within radius of badguy, his growthfactor increases by 1 each time interval
                //Debug.Log("growfactor: " + growfactor + "framecounter: " + framecounter);
                growfactor += 1;
            }
            framecounter += 1;
            if (transform.localScale[0] < 10)
            //if player is smaller that scale 10 he starts growing each frame by the magnitude of his growthfactor
            {
                transform.localScale += new Vector3(growrate * growfactor, growrate * growfactor, growrate * growfactor);
            }
        }
        else
        {
            growfactor = 1;
            framecounter = 0;
            if (transform.localScale[0] > 1)
            {
                transform.localScale -= new Vector3(shrinkrate, shrinkrate, shrinkrate);

            }
        }
    }
    void checkRange()
    {
        /*Debug.Log(transform.position);*/
        foreach (Vector3 a in badposlist)
        {
            //iterates over each badguy position
            if ((transform.position - a).sqrMagnitude < distance * distance)
            {
                // checks distance between player and badguy position
                //Debug.Log(a + "is in range");
                isinRange = true;
                break;
            }
            else
            {
                isinRange = false;
            }
            //Debug.Log(isinRange);
        }
    }
}