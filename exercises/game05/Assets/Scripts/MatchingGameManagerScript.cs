using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchingGameManagerScript : MonoBehaviour
{
	public CharacterScript selectedAnimal;
	public int counter = 0;

	public Text nameText;
	public Text checkHabitat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(counter ==5){
    		SceneManager.LoadScene("Win");
    	} 
    }

    public void SelectAnimal(CharacterScript toSelect){
    	selectedAnimal = toSelect;
    	GameObject[] animals = GameObject.FindGameObjectsWithTag("animal");
    	for (int i = 0; i < animals.Length; i++){
    		CharacterScript characterScript = animals[i].GetComponent<CharacterScript>();
    		characterScript.selected = false;
    		UpdateUI(selectedAnimal);
    	}
    	
    	if(toSelect != null){
    		selectedAnimal.selected = true;
    		UpdateUI(selectedAnimal);
    	}
    	
    }

    public void UpdateUI(CharacterScript animal){
    	nameText.text = animal.animalName;
    	checkHabitat.text = " ";


    }

}
