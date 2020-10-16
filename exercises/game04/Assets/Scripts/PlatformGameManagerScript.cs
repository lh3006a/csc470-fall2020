using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformGameManagerScript : MonoBehaviour
{
	public GameObject antPrefab;
	GameObject ground;
	public Text instructText;
	public float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
    	ground = GameObject.Find("Ground");
    	for(int i = 0; i < 25; i++){
    		Vector3 antPos = new Vector3(ground.transform.position.x + Random.Range(-850, 850), 20, ground.transform.position.z + Random.Range(-850, 850));
    		Vector3 antRotation = new Vector3(0, Random.Range(-180f, 180f), 0);
    		Instantiate(antPrefab, antPos, Quaternion.Euler(antRotation));
    	}
    }

    // Update is called once per frame
    void Update()
    {
    	timer -= Time.deltaTime;
    	if(timer <= 0){
    		instructText.text = "";

    	}
        
    }
}
