using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour {

	public Rigidbody2D rb2d;
	private GameObject gameManager;
	private GameBehavior gameManagerScript;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		gameManager = GameObject.FindGameObjectWithTag ("GameController");
		gameManagerScript = gameManager.GetComponent<GameBehavior> ();
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("bear")) {
			Destroy (other.gameObject);
			gameManagerScript.AddMiss ();
		}

		if (other.gameObject.CompareTag ("cookie")) {
			Destroy (other.gameObject);
		}


	}
}
