using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneScript : MonoBehaviour
{
		public Rigidbody rb;
		public GameObject ring;
		public GameObject applePrefab;

		float speed = 10;
		float forwardSpeed = 1;
		float pitchSpeed = 70;
		float pitchModSpeedRate = 8f;
		float rollSpeed = 70;

		public Text scoreText;
		public int score = 0;
		public Text fuelText;
		float fuel = 35;
		

		public bool doorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
    	scoreText.text = score.ToString();
    	fuelText.text = fuel.ToString();
    	rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

	    float hAxis = Input.GetAxis("Horizontal");
	    float vAxis = Input.GetAxis("Vertical");

	    float xRot = vAxis * pitchSpeed * Time.deltaTime; 
	    float yRot = hAxis * rollSpeed / 4 * Time.deltaTime;
	    float zRot = -hAxis * rollSpeed * Time.deltaTime;
	    transform.Rotate(xRot, yRot, zRot, Space.Self);

	    forwardSpeed += transform.forward.y * pitchModSpeedRate * Time.deltaTime;
	    forwardSpeed = Mathf.Clamp(forwardSpeed, 0, 5f);

	    transform.Translate(transform.forward * speed * forwardSpeed * Time.deltaTime, Space.World);

	    float terrainHeight = Terrain.activeTerrain.SampleHeight(transform.position);
	    if(transform.position.y < terrainHeight){
	    	transform.position = new Vector3(transform.position.x, terrainHeight, transform.position.z);
	    }

	    fuel -= Time.deltaTime;
    	fuelText.text = fuel.ToString();
    	
    	if(fuel <= 0){
    		forwardSpeed = 0;
    		rb.isKinematic = false;
    		rb.useGravity = true;
   		}
	    Vector3 cameraPosition = transform.position - transform.forward * 12 + Vector3.up * 5;
	    Camera.main.transform.position = cameraPosition;
	    Vector3 lookAtPos = transform.position + transform.forward * 8;
	    Camera.main.transform.LookAt(lookAtPos, Vector3.up);

    }
    private void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("apple")){
    		Debug.Log("hit");
    		Destroy(other.gameObject);
    		fuel += 3f;
    		fuelText.text = fuel.ToString();
    		score++;
    		scoreText.text = score.ToString();
    	}
    	else if(other.CompareTag("ring")){
    		Debug.Log("door");
    		doorOpen = true;
    	}
    	
    }
}
