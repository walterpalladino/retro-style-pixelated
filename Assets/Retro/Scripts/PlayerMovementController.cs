using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

	public float sideSpeed = 3.0f;
	public float frontalSpeed = 3.0f;


	public ParallaxController parallaxController;

	private Vector3 _startPosition = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var x = Input.GetAxis("Horizontal") * sideSpeed;
        var z = Input.GetAxis("Vertical") * frontalSpeed;

        transform.Rotate(0, x * Time.deltaTime, 0);
        transform.Translate(0, 0, z * Time.deltaTime);

        if (x != 0.0f) {
	        parallaxController.sideSpeed = x ;        	
        } else {
	        parallaxController.sideSpeed = 0.0f ;        	
        }
    
        if (z != 0.0f) {
	        parallaxController.frontalSpeed = z ;
        } else {
	        parallaxController.frontalSpeed = 0.0f ;        	
		}

	}

}
