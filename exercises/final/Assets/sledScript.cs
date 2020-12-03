using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sledScript : MonoBehaviour
{
	Renderer rend;
	public string selectedCharacter = "SelectedCharacter";
    // Start is called before the first frame update
    void Start()
    {
    	rend = gameObject.GetComponentInChildren<Renderer>();
    	int getCharacter;
    	getCharacter = PlayerPrefs.GetInt(selectedCharacter);
    	switch(getCharacter)
    	{
    		case 1:
    			rend.material.color = Color.red;
    			break;
    		case 2:
    			rend.material.color = Color.green;
    			break;
    		case 3:
    			rend.material.color = Color.blue;
    			break;
    		case 4:
    			rend.material.color = new Color(0.6042905f, 0, 1, 1);
    			break;
    		case 5:
    			rend.material.color = Color.yellow;
    			break;
    		default:
    			rend.material.color = Color.yellow;
    			break;
    	}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
