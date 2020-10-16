using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{
	float moveSpeed = 95;
	float rotateSpeed = 85;

	public CharacterController cc;

	bool prevIsGrounded = false;

	float yVelocity = 0;
	float jumpForce = 1f;
	float gravityModifier = 0.2f;

	public Text wheatText;
	public int wheat = 0;
	public GameObject piePrefab;
	public GameObject pointLightPrefab;
	public GameObject antPrefab;
	int x = 0;
	public Text winText;
	//string win = "You Win!";
	
	// Start is called before the first frame update
	void Start()
	{
		cc = gameObject.GetComponent<CharacterController>();
		wheat = 0;
		wheatText.text = wheat.ToString();
	}
	
	// Update is called once per frame
	void Update()
	{
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);

		if (!cc.isGrounded) { 
			yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;
		} else {
			if (!prevIsGrounded) {
				yVelocity = 0;
			}

			if (Input.GetKeyDown(KeyCode.Space)) {
				yVelocity = jumpForce;
			}
		}
		Vector3 amountToMove = transform.forward * vAxis * moveSpeed * Time.deltaTime;
		amountToMove.y = yVelocity;

		cc.Move(amountToMove);

		prevIsGrounded = cc.isGrounded;

		Vector3 cameraPosition = transform.position - transform.forward * 175 + Vector3.up * 20;
	    Camera.main.transform.position = cameraPosition;
	    Vector3 lookAtPos = transform.position + transform.forward * 20;
	    Camera.main.transform.LookAt(lookAtPos, Vector3.up);

	    if(wheat == 3){
	    	while(x == 0){
	    		Vector3 piePos = new Vector3(-579, 100, -245);
	    		Vector3 lightPos = new Vector3(-579, 200, -245);
	   			Instantiate(piePrefab, piePos, Quaternion.identity);
	   			Instantiate(pointLightPrefab, lightPos, Quaternion.identity);
	   			x++;
	    	}
	    }
	}
	private void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("wheat")){
			Destroy(other.gameObject);
			wheat++;
			wheatText.text = wheat.ToString();
		}
		else if(other.gameObject.CompareTag("ant")){
			Debug.Log("ant");
			wheat--;
			wheatText.text = wheat.ToString();
			
		}
		else if(other.gameObject.CompareTag("pie")){
			Destroy(other.gameObject);
			winText.text = "You Win!";
		}
	}
}