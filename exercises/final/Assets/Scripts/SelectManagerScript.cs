using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectManagerScript : MonoBehaviour
{
   public GameObject yellowSled;
   public GameObject redSled;
   public GameObject greenSled;
   public GameObject blueSled;
   public GameObject purpleSled;
   public int characterInt = 1;
   private string selectedCharacter = "SelectedCharacter";


   void Start(){

   }
   public void NextCharacter(){
   		switch(characterInt){
   		case 1:
   			PlayerPrefs.SetInt(selectedCharacter, 1);
   			yellowSled.SetActive(false);
   			redSled.SetActive(true);
   			characterInt++;
   			break;
   		case 2:
   			PlayerPrefs.SetInt(selectedCharacter, 2);
   			redSled.SetActive(false);
   			greenSled.SetActive(true);
   			characterInt++;
   			break;
   		case 3:
   			PlayerPrefs.SetInt(selectedCharacter, 3);
   			greenSled.SetActive(false);
   			blueSled.SetActive(true);
   			characterInt++;
   			break;
   		case 4:
   			PlayerPrefs.SetInt(selectedCharacter, 4);
   			blueSled.SetActive(false);
   			purpleSled.SetActive(true);
   			characterInt++;
   			break;
   		case 5:
   			PlayerPrefs.SetInt(selectedCharacter, 5);
   			purpleSled.SetActive(false);
   			yellowSled.SetActive(true);
   			characterInt++;
   			ResetInt();
   			break;
   		default:
   			ResetInt();
   			break;
   		}
   }

   public void PreviousCharacter(){
   		switch(characterInt){
   		case 1:
   			PlayerPrefs.SetInt(selectedCharacter, 4);
   			yellowSled.SetActive(false);
   			purpleSled.SetActive(true);
   			characterInt--;
   			ResetInt();
   			break;
   		case 2:
   			PlayerPrefs.SetInt(selectedCharacter, 5);
   			redSled.SetActive(false);
   			yellowSled.SetActive(true);
   			characterInt--;
   			break;
   		case 3:
   			PlayerPrefs.SetInt(selectedCharacter, 1);
   			greenSled.SetActive(false);
   			redSled.SetActive(true);
   			characterInt--;
   			break;
   		case 4:
   			PlayerPrefs.SetInt(selectedCharacter, 2);
   			blueSled.SetActive(false);
   			greenSled.SetActive(true);
   			characterInt--;
   			break;
   		case 5:
   			PlayerPrefs.SetInt(selectedCharacter, 3);
   			purpleSled.SetActive(false);
   			blueSled.SetActive(true);
   			characterInt--;
   			break;
   		default:
   			ResetInt();
   			break;
   		}

   }
   public void ResetInt(){
   		if(characterInt >=5){
   			characterInt = 1;
   		}
   		else{
   			characterInt = 5;
   		}
   }
   public void PlayGame(){
   		SceneManager.LoadScene("Game");
   }

}
