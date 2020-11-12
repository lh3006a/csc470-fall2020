using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	//public CharacterScript selectedAnimal;
	public LearnAnimalsScript learnSelectedAnimal;

	public GameObject namePanel;
	public Text nameText;
	public Text dietText;
	public Text habitatText;
	public Image animalImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectAnimal(LearnAnimalsScript toSelect){
    	learnSelectedAnimal = toSelect;
    	GameObject[] animals = GameObject.FindGameObjectsWithTag("animal");
    	for (int i = 0; i < animals.Length; i++){
    		LearnAnimalsScript learnAnimalsScript = animals[i].GetComponent<LearnAnimalsScript>();

    		learnAnimalsScript.selected = false;
    		UpdateUI(learnSelectedAnimal);
    	}
    	
    	if(toSelect != null){
    		learnSelectedAnimal.selected = true;
    		UpdateUI(learnSelectedAnimal);
    	}
    	
    }
    

    //public void UpdateUI(CharacterScript animal){
    public void UpdateUI(LearnAnimalsScript animal){
    	nameText.text = animal.animalName;
    	dietText.text = animal.animalDiet;
    	habitatText.text = animal.animalHabitat;
    	animalImage.sprite = animal.animalSprite;
    	namePanel.SetActive(true);
    }

    public void GoToInstructions(){
    	SceneManager.LoadScene("Instructions");
    }

    public void GoToLearnAnimals(){
    	SceneManager.LoadScene("LearnAnimals");
    }
    public void GoToMatching(){
    	SceneManager.LoadScene("Matching");
    }
}
