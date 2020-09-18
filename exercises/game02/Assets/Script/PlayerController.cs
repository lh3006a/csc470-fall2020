using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	float speed = 12f;
	int score = 0;
	public Text scoreText;
	GameObject dinosaur;

    // Start is called before the first frame update
    void Start()
    {
    	dinosaur = GameObject.Find("Dino");  
    }

    // Update is called once per frame
    void Update()
    {
    	
    	if(Input.GetKey("left")){
    		transform.Translate((transform.forward* -1) * Time.deltaTime * speed); 
    	}
    	if(Input.GetKey("right")){
    		transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z+.1f * 3));
    	}
    	if(Input.GetKey("up")){
    		transform.position = new Vector3((transform.position.x-.1f* 3), transform.position.y, transform.position.z);
    	}
    	if(Input.GetKey("down")){
    		transform.position = new Vector3((transform.position.x+.1f * 3), transform.position.y, transform.position.z); 
    	}
    }
    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.CompareTag("Apple")){
    		score += 1;
    		Debug.Log(score);
    		
    		DinoChase dino = dinosaur.GetComponent<DinoChase>();

    		/**if(!apple.getBunny){
    			apple.getBunny = true;
    			Destroy(other.gameObject, 10f);
    		}
    		**/
    		if(!dino.getBunny){
    			dino.getBunny = true;
    			
    		}
    			//score = score + 1;
    		Destroy(other.gameObject);
    			
    		scoreText.text = score.ToString();


    		
    	}
    }

}
