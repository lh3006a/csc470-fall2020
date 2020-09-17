using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject carrotPrefab;
	public GameObject applePrefab;
	public GameObject turnipPrefab;
	GameObject ground;
	float findApplesTimer = 10f;
	float middleTimer = 3f;
	float middleTimerRate = 3f;
	float appleTimerRate = 10f;
    // Start is called before the first frame update
    void Start()
    {
    	ground = GameObject.Find("Ground");
        
    }

    // Update is called once per frame
    void Update()
    {
  		findApplesTimer -= Time.deltaTime;
  			if(findApplesTimer < 0){
  				Vector3 turnipPos = new Vector3(ground.transform.position.x + Random.Range(-25, 25), 
    				ground.transform.position.y+5f, ground.transform.position.z + Random.Range(-25,25));
    			GameObject turnip = Instantiate(turnipPrefab, turnipPos, Quaternion.identity);
    			Destroy(turnip, 7f);
    			middleTimer -= Time.deltaTime;
    			if(middleTimer < 0){
    				findApplesTimer = appleTimerRate;
    				middleTimer = middleTimerRate;	
	
    			}
    			//Debug.Log("done");
  			}
    }
     public void MakeCarrots()
    {
    	//Debug.Log("make carrots");
    	int i = 0;
    	while(i<=Random.value*5){
    		Vector3 carrotPos = new Vector3(ground.transform.position.x + Random.Range(-25, 25), 
    			ground.transform.position.y+2f, ground.transform.position.z + Random.Range(-25,25));
    		Vector3 applePos = new Vector3(ground.transform.position.x + Random.Range(-15, 15), 
    			ground.transform.position.y+2f, ground.transform.position.z + Random.Range(-15,15));
    		Instantiate(carrotPrefab, carrotPos, Quaternion.identity);
    		if(i == 3){
    			Instantiate(applePrefab, applePos, Quaternion.identity);
    		}
    		i++;
    	}
    		
    	//}
    }
}
