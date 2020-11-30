using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	//MusicScript winterSong;
	// PlayerScript player;
	// public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
    	GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().PlayMusic();
    	//winterSong.PlayMusic();
    	// player = GameObject.Find("Player").GetComponent<PlayerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	//GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().PlayMusic();
    	// if(player.won = false){
    	// 	timer -= Time.deltaTime;
    	// 	if(timer <= 0){
    	// 		GoToTitle();
    	// 	}
    	// }
        
    }
    
    public void GoToInstructions(){
    	SceneManager.LoadScene("Instructions");
    }

    public void GoToTitle(){
    	SceneManager.LoadScene("Title");
    }

    public void GoToGame(){
    	//GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().StopMusic();
    	//winterSong.StopMusic();
    	SceneManager.LoadScene("Game");
    }
}
