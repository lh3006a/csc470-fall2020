using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	 public static MusicScript instance;

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
		if(!instance){
			instance = this;
		}
		else{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
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

		// if(song == null){
		// 	song = transform.gameObject;
		// 	DontDestroyOnLoad(song);
		// }
		// else{
		// 	Destroy(this.gameObject);
		// }
		//DontDestroyOnLoad(transform.gameObject);
		
		//winterSong = GetComponent<AudioSource>();
	}
	void Start(){

	}

	void Update(){

	}

}
