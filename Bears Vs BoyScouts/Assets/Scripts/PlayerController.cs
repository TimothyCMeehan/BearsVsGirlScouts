using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D hiro;
	public int speed;

	private GameObject gameManager;
	private GameBehavior gameManagerScript;
	private SpriteRenderer playerSprite;

	// Use this for initialization
	void Start () {
		hiro = GetComponent<Rigidbody2D> ();
		playerSprite = GetComponent<SpriteRenderer> ();
		gameManager = GameObject.FindGameObjectWithTag ("GameController");
		gameManagerScript = gameManager.GetComponent<GameBehavior> ();


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			//spriteDirection = "left";
			playerSprite.flipX = true;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			//spriteDirection = "right";
			playerSprite.flipX = false;
		
		} 
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("bear")) {
			gameManagerScript.BearsWin ();
			Destroy (gameObject);
		}
	}
}
