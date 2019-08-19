using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{

	[HideInInspector]
	public float roadSpeed = 0.0f;
	[HideInInspector]
	public float sideSlide = 0.0f;

	[SerializeField]
	private GameObject[] _roadPieces;

	//	This value should change, will works only for this straight pieces used for testing
	private float _roadSize = 12.0f;
	private float _maxSideSlide = 4.0f;
	private float _slideSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((roadSpeed != 0) || (sideSlide != 0)) {
        	UpdateRoad();
        }
    }

	//	Update Road position based on speed
    private void UpdateRoad () {

    	for (int r = 0; r < _roadPieces.Length; r++) {
	    	
	    	Vector3 pos = _roadPieces[r].transform.position;
	    	
	    	pos.z -= roadSpeed;
	    	//	If the track is out of sight recycle it
	    	if (pos.z < -2*_roadSize) {
	    		pos.z += 4 * _roadSize;
	    	}

	    	pos.x -= sideSlide * _slideSpeed;
	    	//	Clamp movement on both sides of the road
	    	if (pos.x > _maxSideSlide) {
	    		pos.x = _maxSideSlide;
	    	} else if (pos.x < -_maxSideSlide) {
	    		pos.x = -_maxSideSlide;
	    	}

	    	//	Update the track position
	    	_roadPieces[r].transform.position = pos;
    	}
    }
}
