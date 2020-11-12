using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterScript : MonoBehaviour
{
	MatchingGameManagerScript gm;
	public bool selected = false;
	public string animalName;
	public string type;
	public float homex;
	public float homez;
	public bool correctHome;


	Vector3 targetPosition;
	public float rotateSpeed = 3f;
	public float speed = 5f;
	public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
    	gm = GameObject.Find("MatchingGameManager").GetComponent<MatchingGameManagerScript>();
    	targetPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (selected) {
			if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit)) {
					if ((hit.collider.gameObject.layer == LayerMask.NameToLayer("Ground")) ||(hit.collider.gameObject.layer == LayerMask.NameToLayer("Wall"))) {
						GameObject obj = new GameObject("hit");
						obj.transform.position = hit.point;
						//targetPosition = obj.transform.position;
						targetPosition = new Vector3(obj.transform.position.x, 0.0f, obj.transform.position.z);
						//Debug.Log(targetPosition.x);
						//Debug.Log(this.homex);
						//if((targetPosition.x == this.homex && targetPosition.z == this.homez) || correctHome){
							//targetPosition = (this.homex, 0.0f, this.homez); 
						//}
						
					}
				} else {
					gm.SelectAnimal(null);
				}
			}
		}

		if (Vector3.Distance(transform.position, targetPosition) > 0.5f) {
			if(correctHome){
				transform.position = new Vector3(homex, 0.0f, homez);
			}
			else{
				Vector3 vectorToTarget = targetPosition - transform.position;
				vectorToTarget = vectorToTarget.normalized;

				float step = rotateSpeed * Time.deltaTime;

				Vector3 newDirection = Vector3.RotateTowards(transform.forward, vectorToTarget, step, 1);
				transform.rotation = Quaternion.LookRotation(newDirection);
			
				cc.Move(transform.forward * speed * Time.deltaTime);
			}	
		}
        
    }

    
    public void OnMouseDown(){
    	selected = !selected;
    	if(selected){
    		gm.SelectAnimal(this);
    	}
    }  

}
