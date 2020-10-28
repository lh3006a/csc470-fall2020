using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
	GameManager gm;
	
	public string animalName;
	public string animalDiet;
	public string animalHabitat;
	public bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(selected){
    		if(Input.GetMouseButtonDown(0)){

    		}
    	}
        
    }
    public void OnMouseDown(){
    	selected = !selected;
    	if(selected){
    		gm.SelectAnimal(this);
    	}
    }
    /**public void UpdateVisuals(){
    	if(selected){

    	}
    }
    **/
}
