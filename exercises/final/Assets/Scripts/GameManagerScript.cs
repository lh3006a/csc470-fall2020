using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	public static GameManagerScript instance;
	PlayerScript player;
	
	public Text collectedCount;

	public Image hitImage;
	float fadeRate = 0.5f;
	Coroutine hitCoroutine;

	public bool game;

    private void Awake(){
    	if(instance != null && instance != this){
    		Destroy(gameObject);
    	}
    	else{
    		instance = this;
    		//DontDestroyOnLoad(this.gameObject);
    	}
    }
    void Start()
    {
    	game = true;

    	//Debug.Log(MusicGameObject);
    	//GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().StopMusic();
    	//GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().mute = true;

    	player = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
    	collectedCount.text = player.collected.ToString();
    	if(player.hit){
    		hitCoroutine = StartCoroutine(hitIn());
   		}

    }

    IEnumerator hitIn(){

    	hitImage.color = new Color(hitImage.color.r, hitImage.color.g, hitImage.color.b, 1);
    	while(hitImage.color.a >= 0){
    		hitImage.color = new Color(hitImage.color.r, hitImage.color.g,hitImage.color.b, hitImage.color.a - fadeRate * Time.deltaTime);
    		yield return null;
    	}
    	player.hit = false;
    }
}
