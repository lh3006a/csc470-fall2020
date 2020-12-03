using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	//MusicScript winterSong;
	// PlayerScript player;
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

    public void GoToSledSelection(){
    	SceneManager.LoadScene("PickSprite");
    }
}
