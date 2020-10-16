using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antScript : MonoBehaviour
{
	public CharacterController ant;
	public float speed = 70f;
	//public static float speed = 5f;
	//public Vector3 userDirection(Vector3.right);
    // Start is called before the first frame update
    void Start()
    {
    	ant = gameObject.GetComponent<CharacterController>();
    	/**var rb = GetComponent<Rigidbody>();
    	rb.velocity = RandomVector(0f, 25f);
    	**/
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 amountToMove = transform.forward * speed * Time.deltaTime;
    	ant.Move(amountToMove);
    	//get reference to character controller and call move
    	//transform.position += Vector3.forward * Time.deltaTime * speed;
    	//tranform.Translate(userDirection * speed * Time.deltaTime);
        
    }
    /**
    private Vector3 RandomVector(float min, float max){
    	var x = Random.Range(min, max);
    	//var y = Random.Range(min, max)
    	var z = Random.Range(min, max);
    	return new Vector3(x,transform.position.y, z);
    }
    **/
}
