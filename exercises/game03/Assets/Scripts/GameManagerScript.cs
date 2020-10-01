using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
	public GameObject cellPrefab;
	public GameObject ballPrefab;
	GameObject ground;
	public CellScript[,] grid;

	int gridWidth = 50;
	int gridHeight = 50;
	float cellDimension = 0.5f;
	float padding = 0.1f;
	public static int aliveScore;
	public static int deadScore;

	int time = 0;
	float timer = 0;
	float timerRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
    	grid = new CellScript[gridWidth, gridHeight];
    	for (int x = 0; x < gridWidth; x++){
    		for(int y =0; y < gridHeight; y++){
    			Vector3 pos = new Vector3(x *(cellDimension + padding), 0, y *(cellDimension + padding));
    			GameObject cellOb = Instantiate(cellPrefab, pos, Quaternion.identity);
    			cellOb.transform.localScale = new Vector3(cellDimension, cellDimension, cellDimension);
    			CellScript cs = cellOb.GetComponent<CellScript>();
    			cs.x = x;
    			cs.y = y;
    			grid[x,y] = cs;
    		}
    	}
    	ground = GameObject.Find("Ground");

        
    }

    // Update is called once per frame
    void Update()
    {
    	timer -= Time.deltaTime;
    	if(timer < 0){
    		generateNextState();
    		timer = timerRate;
    	}
        
    }
    void generateNextState()
    {
    	time++;
    	for(int x = 0; x < gridWidth; x++){
    		for(int y = 0; y < gridHeight; y++){
    			List<CellScript> liveNeighbors = gatherLiveNeighbors(x,y);
    			if(grid[x,y].Alive && liveNeighbors.Count <2){
    				grid[x,y].nextAlive = false;
    			}
    			else if (grid[x,y].Alive && (liveNeighbors.Count == 2 || liveNeighbors.Count == 3)){
    				grid[x,y].nextAlive = true;
    			}
    			else if (grid[x,y].Alive && liveNeighbors.Count > 3){
    				grid[x,y].nextAlive = false;
    			}
    			else if (!grid[x,y].Alive && liveNeighbors.Count == 3){
    				grid[x,y].nextAlive = true;
    			}
    		}

    	}
    	for(int x = 0; x < gridWidth; x++){
    		for(int y = 0; y < gridHeight; y++){
    			grid[x,y].Alive = grid[x,y].nextAlive;
    		}
    	}
    }
    List<CellScript> gatherLiveNeighbors(int x, int y)
    {
    	List<CellScript> liveNeighbors = new List<CellScript>();
    	for(int i = Mathf.Max(0, x-1); i <= Mathf.Min(gridWidth - 1, x + 1); i++){
    		for(int j = Mathf.Max(0, y-1); j <= Mathf.Min(gridHeight - 1, y + 1); j++){
    			if(!(x == i && y == j)){
    				if(grid[i,j].Alive){
    					liveNeighbors.Add(grid[i,j]);
    				}
    			}
    		}
    	}
    	return liveNeighbors;
    }
    public void BallDrop()
    {
    	Debug.Log("click");
    	for(int i = 0; i<=7; i++){
    		Vector3 ballPos = new Vector3(ground.transform.position.x + Random.Range(-30,30),
    		ground.transform.position.y + 30f, ground.transform.position.z+ Random.Range(-30,30));
    		Instantiate(ballPrefab, ballPos, Quaternion.identity);
    	}
    	
    }
    
}
