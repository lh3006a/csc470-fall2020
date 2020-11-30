using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
	public float timer = 2f;

	ButtonManager button;
    // Start is called before the first frame update
    void Start()
    {
    	button = GameObject.Find("GameButton").GetComponent<ButtonManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	timer -= Time.deltaTime;
    	if(timer <= 0){
    		button.GoToTitle();

    	}
        
    }
}
