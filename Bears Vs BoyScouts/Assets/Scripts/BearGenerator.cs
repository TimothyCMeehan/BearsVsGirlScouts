using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearGenerator : MonoBehaviour {

	// bear animated gif: http://www.egitimevi.net/hareketli-resim/hayvan/anima047.gif

	public Rigidbody2D bear;
	public int frameDelta;
	private int counter;
	private int leftThisLevel;
	private int waveSize;

	// Use this for initialization
	void Start () {
		counter = 1;
		leftThisLevel = 20;
	}
	
	// Update is called once per frame
	void Update () {
		counter++;
		if (counter % frameDelta == 0) {

			waveSize = Random.Range (1, 6);
			if (waveSize > leftThisLevel) {
			
				waveSize = leftThisLevel;
			
			}

			for (int i = 0; i < waveSize; i++) {
				leftThisLevel--;
				Rigidbody2D bearClone = (Rigidbody2D)Instantiate (bear, transform.position, transform.rotation);
			}
		}
	}
}
