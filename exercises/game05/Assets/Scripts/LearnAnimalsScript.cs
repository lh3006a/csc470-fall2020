using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearnAnimalsScript : MonoBehaviour
{
	GameManagerScript gm;
	
	public string animalName;
	public string animalDiet;
	public string animalHabitat;
	public Sprite animalSprite;
	public bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
    	gm = GameObject.Find("LearnGameManager").GetComponent<GameManagerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown(){
    	selected = !selected;
    	if(selected){
    		gm.SelectAnimal(this);
    	}
    }
}
