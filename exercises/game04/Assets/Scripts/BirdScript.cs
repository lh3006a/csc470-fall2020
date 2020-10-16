using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
	public CharacterController bird;
	public float speed = 70f;
    // Start is called before the first frame update
    void Start()
    {
    	bird = gameObject.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 amountToMove = transform.forward * speed * Time.deltaTime;
    	bird.Move(amountToMove);
        
    }
}
