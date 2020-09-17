using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoChase : MonoBehaviour
{
	public bool getBunny = false;
	GameObject bunny;
    // Start is called before the first frame update
    void Start()
    {
    	bunny = GameObject.Find("Bunny");
        
    }

    // Update is called once per frame
    void Update()
    {
       if(getBunny){
       	Vector3 bunnySpot = bunny.transform.position - transform.position;
       	bunnySpot = bunnySpot.normalized;
       	transform.Translate(bunnySpot * Time.deltaTime * 8);
       } 
    }
}
