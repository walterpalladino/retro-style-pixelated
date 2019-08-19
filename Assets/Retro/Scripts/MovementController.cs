using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {


	public float sideSpeed = 3.0f;
	public float frontalSpeed = 3.0f;


	public ParallaxController parallaxController;
	public RoadManager roadManager;

	private Vector3 _startPosition = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var x = Input.GetAxis("Horizontal") * sideSpeed;
        var z = Input.GetAxis("Vertical") * frontalSpeed;

        if (x != 0.0f) {
	        parallaxController.sideSpeed = x ;        
	        roadManager.sideSlide = x;	
        } else {
	        parallaxController.sideSpeed = 0.0f ;     
	        roadManager.sideSlide = 0.0f;   	
        }
    
        if (z != 0.0f) {
	        parallaxController.frontalSpeed = z ;
	        roadManager.roadSpeed = z;
        } else {
	        parallaxController.frontalSpeed = 0.0f ;    
	        roadManager.roadSpeed = 0.0f;    	
		}

	}
}
