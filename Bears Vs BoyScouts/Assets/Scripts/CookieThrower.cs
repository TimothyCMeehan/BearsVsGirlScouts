using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieThrower : MonoBehaviour {

	//see GameBehavior for audio credits

	//I implemented a cookie box for the hero to collect ammo.  The hero just bumps into the box to gain one cookie
	//I only allowed the hero to shoot horizontally because it adds difficulty and seemed like the minimum viable product.

	private int cookies;
	public Rigidbody2D cookie;
	public Text cookieText;
	public AudioSource bowler;
	public AudioSource chaChing;

	void Start () {
		cookies = 0;
	}

	void Update () {
		if ((Input.GetMouseButtonDown(0)) && (cookies > 0)) {
			bowler.Play ();
			Rigidbody2D cookieClone = (Rigidbody2D)Instantiate (cookie, transform.position, transform.rotation);
			cookies--;
			cookieText.text = "Cookies: " + cookies;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("cookieBox")) {
			chaChing.Play ();
			cookies++;
			cookieText.text = "Cookies: " + cookies;
		}
	}
}
