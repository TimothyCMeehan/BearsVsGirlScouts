using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBehavior : MonoBehaviour {

	// bear animated gif: http://www.egitimevi.net/hareketli-resim/hayvan/anima047.gif

	public Rigidbody2D bear;
	private float speed;
	private int row;
	private int column;
	private float posY;
	private float posX;

	// Use this for initialization
	void Start () {
		bear = GetComponent<Rigidbody2D> ();
		speed = 0.033f;
		//create rows and columns then place bear randomly in position
		row = Random.Range (0, 4);
		posY = row * 2.2f - 4;
		column = Random.Range (0, 5);
		posX = column * 1.8f + 10.5f;
		transform.position = new Vector3 (posX, posY, 0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		posX = posX - speed;
		//bear.AddForce (gameObject.transform.right * speed * (Time.deltaTime * 550) * -1);
		transform.position = new Vector3 (posX, posY, 0f);
	}
}
