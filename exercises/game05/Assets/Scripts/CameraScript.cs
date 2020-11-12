using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey("left")){
    		transform.position = new Vector3((transform.position.x-.1f *3), transform.position.y, transform.position.z);
    	}
    	if(Input.GetKey("right")){
    		transform.position = new Vector3((transform.position.x+.1f *3), transform.position.y, transform.position.z);
    	}
    	if(Input.GetKey("up")){
    		transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z + .1f * 3));
    	}
    	if(Input.GetKey("down")){
    		transform.Translate((transform.forward* -1 * Time.deltaTime * speed));
    	}
        
    }
}
