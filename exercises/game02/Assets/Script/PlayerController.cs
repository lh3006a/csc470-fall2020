using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	float speed = 10f;
	int score = 0;
	public Text scoreText;
	GameObject dinosaur;

	//rb = GetComponent<Rigidbody>();
	/**private float movementX;
	private float movementY;
	private float movementZ;
	**/
    // Start is called before the first frame update
    void Start()
    {
    	dinosaur = GameObject.Find("Dino");  
    }

    // Update is called once per frame
    void Update()
    {
    	//transform.rotation = new Vector3(-2.955f, -2.109f, -3.613f);
    	/**if(rotation.x != -2.995){
    		transform.rotation.x = -2.955;
    	}
    	if(rotation.y != -2.109){
    		transform.rotation.y = -2.109;
    	}
    	if(rotation.z != -3.613){
    		transform.rotation.z = -3.613;
    	}
    	**/
    	//transform.rotation(-2.955f, -2.109f, -3.613f);
    	/**if (Input.GetKeyDown("space")){
    		transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    		//transform.Translate(transform.forward * Time.deltaTime * speed);
    		transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    		transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    		transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    		
    		Debug.Log("space");   
    	}
		**/
    	if(Input.GetKey("left")){
    		transform.Translate((transform.forward* -1) * Time.deltaTime * speed); 
    	}
    	if(Input.GetKey("right")){
    		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+.1f);
    	}
    	if(Input.GetKey("up")){
    		transform.position = new Vector3(transform.position.x-.1f, transform.position.y, transform.position.z);
    	}
    	if(Input.GetKey("down")){
    		transform.position = new Vector3(transform.position.x+.1f, transform.position.y, transform.position.z); 
    	}
    }
    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.CompareTag("Apple")){
    		
    		
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
    			score += 1;
    			Debug.Log(score);
    			scoreText.text = score.ToString();


    		
    	}
    }
    
    /**void OnMove(InputValue movementValue)
    {

    	Vector3 movementVector = movementValue.Get<Vector3>();
    	movementX = movementVector.x;
    	movementY = movementVector.y;
    	movementZ = movementVector.z;

    }
    void FixedUpdate()
    {
    	rb.AddForce(movement * 5);
    }
    **/
}
