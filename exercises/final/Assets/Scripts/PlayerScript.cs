using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class PlayerScript : MonoBehaviour
{
	float moveSpeed = 35f;
	float rotateSpeed = 85f;

	public CharacterController cc;

	public bool moving = false;

	public int collected = 0;
	public bool hit = false;

	public MeterScript meter;
	int cheer = 100;

	public TMP_Text notEnoughText;
	public float timer;

	public bool won;

    // Start is called before the first frame update
    void Start()
    {
    	cc = gameObject.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	
    	float hAxis = Input.GetAxis("Horizontal");
    	float vAxis = Input.GetAxis("Vertical");
    	if(hAxis!= 0 || vAxis!= 0){
    		moving = true;
    	}
    	else{
    		moving = false;
    	}

    	transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);

    	Vector3 amountToMove = transform.forward * vAxis * moveSpeed * Time.deltaTime;
    	cc.Move(amountToMove);
    	timer -= Time.deltaTime;
    	if(timer <= 0){
    		notEnoughText.text = "";
    	}
        
    }

    public void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("Gift")){
    		Destroy(other.gameObject);
    		collected = collected + 1;
    	}
    	else if(other.gameObject.CompareTag("TownHall")){
    		if(collected == 6){
    			GoToWin();
    		}
    		else{
    			timer = 1.5f;
    			notEnoughText.text = "Not Enough Items Collected";
    		}
    	}
    	else if(other.gameObject.CompareTag("Snowman")){
    		hit = true;
    		cheer -= 20;
    		meter.SetMeter(cheer / 100f);
    		if(cheer/100f == 0){
    			GoToDone();
    		}
    	}
    	else if(other.gameObject.CompareTag("Shadow")){
    		if(moving == true){
    			hit = true;
    			cheer -= 20;
    			meter.SetMeter(cheer / 100f);
    			if(cheer/100f == 0){
    				GoToDone();
    			}
    		}
    	}
    }
    public void GoToWin(){
    	won = true;
    	SceneManager.LoadScene("Win");
    }
    public void GoToDone(){
    	won = false;
    	SceneManager.LoadScene("GameOver");
    }
}
