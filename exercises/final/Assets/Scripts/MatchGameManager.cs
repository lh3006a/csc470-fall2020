using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MatchGameManager : MonoBehaviour
{
	public int numSelect = 0;
	public CardScript card1;
	public CardScript card2;
	public int score = 0;
	public bool click = false;
	public bool match = true;
	Coroutine notMatch;
	Coroutine check;

	public TMP_Text matchText;
	public TMP_Text scoreText;
	public TMP_Text bonusRound;
	public float timer = 1.5f;
	public float bonusTimer = 1.5f;
	public bool cardsMatch = false;

	public GameObject[] spots;
	public GameObject gingerbreadPrefab;
	public GameObject mittensPrefab;
	public GameObject giftsPrefab;
	public GameObject cocoaPrefab;
	public GameObject skatePrefab;
	public GameObject sledPrefab;
	public int gingerbread = 0;
	public int mittens = 0;
	public int gifts = 0;
	public int cocoa = 0;
	public int skate = 0;
	public int sled = 0;
	public string place;

	

    // Start is called before the first frame update
    void Start()
    {
    	for(int j = 0; j < spots.Length; j++){
    		GameObject temp = spots[j];
    		int randomIndex = Random.Range(j, spots.Length);
    		spots[j] = spots[randomIndex];
    		spots[randomIndex] = temp;
    	}
    	for(int i = 0; i<= spots.Length; i++){
    		if(gingerbread < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(gingerbreadPrefab, spotPos, Quaternion.identity);
    			gingerbread++;
    		}
    		else if(mittens < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(mittensPrefab, spotPos, Quaternion.identity);
    			mittens++;
    		}
    		else if(gifts < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(giftsPrefab, spotPos, Quaternion.identity);
    			gifts++;
    		}
    		else if(cocoa < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(cocoaPrefab, spotPos, Quaternion.identity);
    			cocoa++;
    		}
    		else if(skate < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(skatePrefab, spotPos, Quaternion.identity);
    			skate++;
    		}
    		else if(sled < 2){
    			place = spots[i].name;
    			Vector3 spotPos = GameObject.Find(place).transform.position;
    			Instantiate(sledPrefab, spotPos, Quaternion.identity);
    			sled++;
    		}

    	}
        
    }

    // Update is called once per frame
    void Update()
    {
    	bonusTimer -=Time.deltaTime;
    	if(bonusTimer <= 0){
    		bonusRound.text = " ";
    	}
    	if(cardsMatch){
    	matchText.text = "MATCH";
   			timer -= Time.deltaTime;
   			if(timer <= 0){
   				matchText.text = " ";
   			}
    	}
    	if(score == 6){
    		GoToWin();
    	}
        
    }
    public void CardSelect(CardScript toSelect){
    	cardsMatch = false;
    	timer = 1.5f;
		match = true;
    	if(numSelect == 0){
    		//match = true;
    		//click = false;
    		card1 = toSelect;
    		click = true;
    		match = true;
    		numSelect++;
    	}
    	else if(numSelect == 1){
    		if(card1 != null){
    			card2 = toSelect;
    			click = true;
    			match = true;
    			numSelect++;
    		}
    		else{
    			numSelect = 0;
    			card1 = toSelect;
    			numSelect++;
    			click = true;
    			match = true;
    		}
    	}
    	if(card1 != null && card2 != null){
    		if(card1.tag == card2.tag){
    			check = StartCoroutine(CheckMatch());
    			cardsMatch = true;

    			// score++;
    			// numSelect = 0;
    			// match = true;
    			// click = false;
    		}
    		else{
    			// card1.anim.SetBool("match", false);
    			// card2.anim.SetBool("match", false);
    			// selected1 = false;
    			// selected2 = false;
    			
    			notMatch = StartCoroutine(NotMatch());
    			// numSelect = 0;
    			 // match = false;
    			 // numSelect = 0;
    			//card1 = null;
    			//card2 = null;
    		}
    	}


    }
    IEnumerator NotMatch(){
    	numSelect = 0;
    	match = false;
    	yield return null;
    }

    IEnumerator CheckMatch(){
    	score++;
    	scoreText.text = score.ToString();
   		numSelect = 0;
   		yield return new WaitForSeconds(1.0f);
    	card1 = null;
    	card2 = null;
    }
    public void GoToWin(){
    	SceneManager.LoadScene("Win");
    }
    
}
