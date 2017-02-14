using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour {

	public Rigidbody2D cookie;

	void Awake () {
		cookie  = GetComponent<Rigidbody2D> ();
	}


	// Update is called once per frame
	void Update () {
		//transform.Rotate(Vector3.right * Time.deltaTime);
		transform.Rotate(0, 0, -(Time.deltaTime * 240));
	}
}
