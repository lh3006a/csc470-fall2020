using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
	public GameObject applePrefab;
	public GameObject ring;
	public GameObject birdPrefab;
	PlaneScript plane;
	public Text instructionText;
	float timer = 3f;
	int count = 0;


    // Start is called before the first frame update
    void Start()
    {
    	plane = GameObject.Find("Plane").GetComponent<PlaneScript>();
    	for(int i = 0; i < 150; i++){
    		float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + 
    			Terrain.activeTerrain.terrainData.size.x);
    		float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + 
    			Terrain.activeTerrain.terrainData.size.z);
    		Vector3 pos = new Vector3(x, 0, z);
    		float y = Terrain.activeTerrain.SampleHeight(pos);
    		pos.y = y + Random.Range(50, 90);
    		Instantiate(applePrefab, pos, Quaternion.identity);
    	}
    	for(int i = 0; i < 250; i++){
    		float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + 
    			Terrain.activeTerrain.terrainData.size.x);
    		float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + 
    			Terrain.activeTerrain.terrainData.size.z);
    		Vector3 birdPos = new Vector3(x, 0, z);
    		float y = Terrain.activeTerrain.SampleHeight(birdPos);
    		birdPos.y = y + 150;
    		Vector3 birdRotation = new Vector3(-8, Random.Range(0,360), 98);
    		Instantiate(birdPrefab, birdPos, Quaternion.Euler(birdRotation));
    	}
        
    }
//-66.165
    // Update is called once per frame
    void Update()
    {
    	timer -= Time.deltaTime;
    	if(timer <= 0){
    		instructionText.text = "";
    	}
    	Debug.Log(plane.score);
    	if(plane.score == 3){
    		while(count == 0){
    		Vector3 ringPos = new Vector3(966, 242, 973);
    		Vector3 ringRotation = new Vector3(0, -46, 0);
    		Instantiate(ring, ringPos, Quaternion.Euler(ringRotation));
    		count++;
    		}
    	}
    	
    	if(plane.doorOpen){
    		SceneManager.LoadScene("Platform");
    	}
        
    }
}
