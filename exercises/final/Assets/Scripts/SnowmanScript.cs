using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanScript : MonoBehaviour
{
	public float speed = 2f; 
	public float maxRotation = 45f;
    // Start is called before the first frame update
    void Start()
    {
    	// SetPos(start.position, end.position);
        
    }

    // Update is called once per frame
    void Update()
    {
    	//transform.rotation = Quaternion.Euler(0f, maxRotation * Mathf.Sin(Time.deltaTime * speed), 0f);
    	// SetPos(start.position, end.position);
    	//transform.Rotate(0.0f, 0.0f, 60.0f, Space.Self);
    	//transform.Rotate(Quaternion.Euler(maxRotation * Mathf.Sin(Time.deltaTime * rotateSpeed), 0f, 0f));
       // transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin(Time.deltaTime * rotateSpeed));
    	//works
    	transform.Rotate(new Vector3(0,35,0)* Time.deltaTime);
    	// Debug.Log(transform.rotation.y);
    	// //Debug.Log(transform.localEulerAngles);
    	//  if(transform.rotation.y > 0.15f){
    	//  	transform.Rotate(new Vector3(0, -5, 0) * Time.deltaTime);

    	//  }
    }
    // void SetPos(Vector3 start, Vector3 end){
    // 	var dir = end - start;
    // 	var mid = (dir) / 2.0f + start;
    // 	transform.position = mid;
    // 	transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
    // 	Vector3 scale = transform.localScale;
    // 	scale.y = dir.magnitude * factor;
    // 	transform.localScale = scale;
    // }
}
