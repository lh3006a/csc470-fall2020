using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallScript : MonoBehaviour
{
	MatchingGameManagerScript gm;
	public string type;
	public Text checkHabitat;
	public CharacterScript selectedAnimal;
	public float speed = 5f;

    void Start()
    {
    	gm = GameObject.Find("MatchingGameManager").GetComponent<MatchingGameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
    	//checkHabitat.text = " ";
        
    }
    public void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("animal")){
    		//checkHabitat.text = " ";
    		CharacterScript characterScript = other.GetComponent<CharacterScript>();
    		characterScript.correctHome = false;
    		
    		if(this.type != characterScript.type){
    			checkHabitat.text = "Incorrect habitat";
    			Debug.Log(characterScript.correctHome);
    		}
    		
    		else if (characterScript.type == this.type){
    			checkHabitat.text = "Correct habitat";
    			characterScript.correctHome = true;
    			Debug.Log(characterScript.correctHome);
    			gm.counter ++;
    		}
    		
    	}

    }
}
