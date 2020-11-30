using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanScript : MonoBehaviour
{
	public float rotateSpeed = 2f;
	public float maxRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//transform.Rotate(0.0f, 0.0f, 60.0f, Space.Self);
    	//transform.Rotate(Quaternion.Euler(maxRotation * Mathf.Sin(Time.deltaTime * rotateSpeed), 0f, 0f));
       // transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin(Time.deltaTime * rotateSpeed));
    	transform.Rotate(new Vector3(0,35,0)* Time.deltaTime);
    }
}
