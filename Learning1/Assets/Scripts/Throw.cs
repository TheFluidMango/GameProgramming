using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	public Rigidbody objectToThrow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void Update () {

		if (objectToThrow != null) {
			if (Input.GetButtonUp ("Fire1")) {
				Debug.Log ("FIRE!");
				Rigidbody ball = Instantiate (objectToThrow, transform.position, transform.rotation) as Rigidbody;
				ball.velocity = transform.TransformDirection (Vector3.forward * 10);
			}
		}
	}
}
