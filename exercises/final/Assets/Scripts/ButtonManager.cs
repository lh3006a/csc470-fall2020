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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GoToInstructions(){
    	SceneManager.LoadScene("Instructions");
    }

    public void GoToTitle(){
    	SceneManager.LoadScene("Title");
    }

    public void GoToGame(){
    	SceneManager.LoadScene("Game");
    }

    public void GoToSledSelection(){
    	SceneManager.LoadScene("PickSprite");
    }
}
