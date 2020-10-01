using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour
{

	public Renderer rend;
	public Color aliveColor;
	public Color deadColor;
	public float aliveHeight = .02f;
	public float deadHeight = .01f;

	public int x = -1;
	public int y = -1;
	public Text aliveScoreText;
	public Text deadScoreText;


	public bool nextAlive;
	private bool _alive = false;
    public bool Alive
   	{
        get
        {
            return this._alive;
        }
        set
        {
            this._alive = value;
            
            if (this._alive) {
				rend.material.color = aliveColor;
				transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 1, transform.localScale.z);

			} else {
				rend.material.color = deadColor;
				if(transform.localScale.y >1){
					transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - 1, transform.localScale.z);
				}
			}
		}
    }
    // Start is called before the first frame update
    void Start()
    {
		this.Alive = Random.value < 0.5f; 
		GameObject aliveObj = GameObject.Find("AliveScore");
		aliveScoreText = aliveObj.GetComponent<Text>();
		GameObject deadObj = GameObject.Find("DeadScore");
		deadScoreText = deadObj.GetComponent<Text>();
    }

    public void OnTriggerEnter(Collider other)
   	{
   	   	if(other.gameObject.CompareTag("Ball"))
   	   	{
   	   		if(this.Alive){
   	   			other.GetComponent<Renderer>().material.color = new Color (Random.value, Random.value, Random.value);
   	   			GameManagerScript.aliveScore++;
   	   			aliveScoreText.text = "Alive Score: " + GameManagerScript.aliveScore.ToString();
   	   		}
   	   		else if(!this.Alive){
   	   			other.GetComponent<Renderer>().material.color = new Color (0,0,0);
   	   			GameManagerScript.deadScore++;
   	   			deadScoreText.text = "Dead Score: " + GameManagerScript.deadScore.ToString();


   	   		}
   	   	}

   }

}
