using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	// public static MusicScript instance;

	// private void Awake(){
 //    	if(instance != null && instance != this){
 //    		Destroy(gameObject);
 //    	}
 //    	else{
 //    		instance = this;
 //    		DontDestroyOnLoad(this.gameObject);
 //    	}
 //    }
	public AudioSource winterSong;
	public GameObject song;

	private void Awake(){
		// song = GameObject.Find("MusicGameObject");
		// if(song == null){
		// 	song = this.gameObject;
		// 	song.name = "MusicGameObject";
		// 	DontDestroyOnLoad("MusicGameObject");
		// }
		// else{
		// 	if(this.gameObject.name!= "MusicGameObject"){
		// 		Destroy(this.gameObject);
		// 	}
		// }

		if(song == null){
			song = transform.gameObject;
			DontDestroyOnLoad(song);
		}
		else{
			Destroy(this.gameObject);
		}
		//DontDestroyOnLoad(transform.gameObject);
		
		//winterSong = GetComponent<AudioSource>();
	}
	void Start(){
	// 	Debug.Log(song);
	// 	if(song == null){
	// 		song = transform.gameObject;
	// 		DontDestroyOnLoad(song);
	// 	}
	// 	winterSong = GetComponent<AudioSource>();
	 }

	void Update(){
		// Debug.Log(song);
		// if(song == null){
		// 	song = transform.gameObject;
		// 	DontDestroyOnLoad(song);
		// }
		// winterSong = GetComponent<AudioSource>();

		// if (GameManager.instance.game){
		// 	StopMusic();

		// }

	}
	public void PlayMusic(){
		if(winterSong.isPlaying){
			return;
		}
		winterSong.Play();
	}

	public void StopMusic(){
		winterSong.Stop();
	}

}
