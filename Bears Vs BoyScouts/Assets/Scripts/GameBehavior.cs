using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour {

	//bowling sounds: https://www.freesoundeffects.com/free-sounds/bowling-10102/
	//background music: http://www.bensound.com
	//all other sounds: http://soundbible.com
	// bear animated gif: http://www.egitimevi.net/hareketli-resim/hayvan/anima047.gif

	//I implemented a cookie box for the hero to collect ammo.  The hero just bumps into the box to gain one cookie
	//I only allowed the hero to shoot horizontally because it adds difficulty and seemed like the minimum viable product.

	private int score;
	private int misses;
	private bool gameOver;
	public Text scoreText;
	public Text missText;
	public Text outcomeText;
	public AudioSource sadTrombone;
	public AudioSource cheering;
	public AudioSource growl;
	public AudioSource roar;
	public AudioSource music;

	// Use this for initialization
	void Start () {

		music.Play ();
		score = 0;
		misses = 0;
		gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((score + misses == 20) && (gameOver == false)) {
			cheering.Play ();
			PlayerWins ();
		
		}  
		
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		growl.Play ();
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}

	public void AddMiss ()
	{
		roar.Play ();
		misses += 1;
		UpdateMisses ();
		if (misses == 5) {
		
			BearsWin ();


		}
	}

	void UpdateMisses ()
	{
		missText.text = "Escaped Bears: " + misses;
	}

	public void BearsWin ()
	{
	
		if (gameOver == false) {
		
			sadTrombone.Play ();

		}
		sadTrombone.Play ();
		outcomeText.text = "Bears Win!!";
		gameOver = true;
	
	}

	public void PlayerWins ()
	{
	
		gameOver = true;
		outcomeText.text = "You Win!!";

	}
}
