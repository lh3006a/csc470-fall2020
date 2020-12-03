using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
	public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
    	//button = GameObject.Find("GameButton").GetComponent<ButtonManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	timer -= Time.deltaTime;
    	if(timer <= 0){
    		GoToTitle();

    	}
        
    }
    public void GoToTitle(){
    	SceneManager.LoadScene("Title");
    }
}
