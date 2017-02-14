using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieBehavior : MonoBehaviour {

	private float speed;
	public Rigidbody2D cookie;
	private Vector3 playerPos;
	private GameObject gameManager;
	private GameBehavior gameManagerScript;
	private float posY;
	private float posX;

	// Use this for initialization
	void Start () {

		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		gameManager = GameObject.FindGameObjectWithTag ("GameController");
		gameManagerScript = gameManager.GetComponent<GameBehavior> ();
		posX = playerPos.x;
		posY = playerPos.y;
		cookie  = GetComponent<Rigidbody2D> ();
		speed = 0.12f;
		transform.position = new Vector3 (posX + 0.5f, posY, 0f);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		posX += speed;
		transform.position = new Vector3 (posX, posY, 0f);
		transform.Rotate(Vector3.up, Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("bear")) {
			//crashSound.Play ();
			gameManagerScript.AddScore (1);
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
