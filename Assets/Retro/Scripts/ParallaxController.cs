using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour {


	public GameObject ground;

	public GameObject backgroundLayer1;
	public GameObject backgroundLayer2;
	public GameObject backgroundLayer3;
	public GameObject backgroundLayer4;
	public GameObject backgroundLayer5;


	public float sideSpeed = 0.0f;
	public float frontalSpeed = 0.0f;


	private TextureScroller groundTextureScroller;
	private TextureScroller backgroundLayer1TextureScroller;
	private TextureScroller backgroundLayer2TextureScroller;
	private TextureScroller backgroundLayer3TextureScroller;
	private TextureScroller backgroundLayer4TextureScroller;
	private TextureScroller backgroundLayer5TextureScroller;


	// Use this for initialization
	void Start () {
		
		if (ground) {
			groundTextureScroller	= ground.GetComponent<TextureScroller>();		
		}
		
		if (backgroundLayer1) {
			backgroundLayer1TextureScroller	= backgroundLayer1.GetComponent<TextureScroller>();		
		}
		if (backgroundLayer2) {
			backgroundLayer2TextureScroller	= backgroundLayer2.GetComponent<TextureScroller>();		
		}
		if (backgroundLayer3) {
			backgroundLayer3TextureScroller	= backgroundLayer3.GetComponent<TextureScroller>();		
		}
		if (backgroundLayer4) {
			backgroundLayer4TextureScroller	= backgroundLayer4.GetComponent<TextureScroller>();		
		}
		if (backgroundLayer5) {
			backgroundLayer5TextureScroller	= backgroundLayer5.GetComponent<TextureScroller>();		
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		groundTextureScroller.move = false;
		backgroundLayer1TextureScroller.move = false;
		backgroundLayer2TextureScroller.move = false;
		backgroundLayer3TextureScroller.move = false;
		backgroundLayer4TextureScroller.move = false;
		backgroundLayer5TextureScroller.move = false;

		if (groundTextureScroller) {
			groundTextureScroller.uSpeed = -sideSpeed * 4.0f ;
			groundTextureScroller.vSpeed = -frontalSpeed;
			groundTextureScroller.move = true;
		}
		if (backgroundLayer1TextureScroller) {
			backgroundLayer1TextureScroller.uSpeed = sideSpeed / 128.0f;
			backgroundLayer1TextureScroller.move = true;
		}
		if (backgroundLayer2TextureScroller) {
			backgroundLayer2TextureScroller.uSpeed = sideSpeed / 64.0f;
			backgroundLayer2TextureScroller.move = true;
		}
		if (backgroundLayer3TextureScroller) {
			backgroundLayer3TextureScroller.uSpeed = sideSpeed / 16.0f;
			backgroundLayer3TextureScroller.move = true;
		}
		if (backgroundLayer4TextureScroller) {
			backgroundLayer4TextureScroller.uSpeed = sideSpeed / 4.0f;
			backgroundLayer4TextureScroller.move = true;
		}
		if (backgroundLayer5TextureScroller) {
			backgroundLayer5TextureScroller.uSpeed = sideSpeed ;
			backgroundLayer5TextureScroller.move = true;
		}


	}
}
