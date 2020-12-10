using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
	MatchGameManager gm;
	Animator anim;
	public bool selected = false;
	Coroutine noMatch;

	public Color defaultColor;
	public Color selectedColor;

	public Renderer rend;
	// public bool selected1 = false;
	// public bool selected2 = false;
	// public CardScript card1;
	// public CardScript card2;
	// public int numSelect = 0;
	// public int score = 0;
	//public bool card1 = false;
	//public bool card2 = false;

    // Start is called before the first frame update
    void Start()
    {
    	gm = GameObject.Find("MatchGameManager").GetComponent<MatchGameManager>();
    	anim = gameObject.GetComponent<Animator>();
        anim.SetBool("match", true);
        anim.SetBool("click", false);
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
    	// if(gm.card1.selected){
    	// 	gm.card1.anim.SetBool("click", true);

    	// }
    	// if(gm.card1 != null){
    	// 	if(gm.card1.selected){
    	// 		gm.card1.anim.SetBool("click", true);
    	// 	}
    	// }
    	// if(gm.card2 != null){
    	// 	if(gm.card2.selected){
    	// 		gm.card2.anim.SetBool("click", true);
    	// 	}
    	// }
    	// if(gm.click == true){
    	// 	if(gm.card1 != null){
    	// 		gm.card1.anim.SetBool("click", true);
    	// 		//Debug.Log(gm.card1.selected);
    	// 	}
    	// 	if(gm.card2 != null){
    	// 		gm.card2.anim.SetBool("click", true);
    	// 		Debug.Log("MEMEEEEE");
    	// 	}
    	// }
    	if(gm.match == false){
    		noMatch = StartCoroutine(NoMatch());
    		// if(gm.card1 != null){
    		// 	gm.card1.anim.SetBool("match", false);
    		// }
    		// if(gm.card2 != null){
    		// 	gm.card2.anim.SetBool("match", false);
    		// }
    		//Sta
    	}

    }

    public void OnMouseDown(){
    	selected = !selected;
    	UpdateColor();
    	if(selected){
    		this.anim.SetBool("click", true);
    		this.anim.SetBool("match", true);
    		gm.CardSelect(this);
    		//this.selected = false;
    	}
    	
    }
    IEnumerator NoMatch(){
    	yield return new WaitForSeconds(2.0f);
    	if(gm.card1 != null){
    			gm.card1.anim.SetBool("match", false);
    			gm.card1.anim.SetBool("click", false);
    			//gm.card1.anim.SetBool("match", true);
    			// yield return new WaitForSeconds(0.5f);
    			// gm.card1.anim.SetBool("match", true);
    			 gm.card1.selected = false;
    			 gm.card1 = null;
    			
    		}
    	if(gm.card2 != null){
    			gm.card2.anim.SetBool("match", false);
    			gm.card2.anim.SetBool("click", false);
    			//gm.card2.anim.SetBool("match", true);
    			//yield return new WaitForSeconds(0.5f);
    			// gm.card2.anim.SetBool("match", true);
    			 gm.card2.selected = false;
    			 gm.card2 = null;

    		}
    	// gm.card1.anim.SetBool("match", true);
    	// gm.card1.selected = false;
    	// gm.card1 = null;
    	// gm.card2.anim.SetBool("match", true);
    	// gm.card2.selected = false;
    	// gm.card2 = null;

    	UpdateColor();
    	gm.match = true;



    }

    public void UpdateColor(){
    	if(selected){
    		rend.material.color = selectedColor;
    	}
    	else{
    		rend.material.color = defaultColor;
    	}
    }
}
