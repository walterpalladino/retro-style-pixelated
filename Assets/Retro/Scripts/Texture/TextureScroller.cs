using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour {


	public float uSpeed = 0.0f;
	public float vSpeed = 0.0f;

	public bool move = false;

	private Renderer _renderer;
	private Vector2 uvOffset;

	// Use this for initialization
	void Start () {
		_renderer = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (move) {
			uvOffset += new Vector2(uSpeed, vSpeed);
	        _renderer.material.SetTextureOffset("_MainTex", uvOffset);
		}

	}
}
