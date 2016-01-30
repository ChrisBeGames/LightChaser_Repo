using UnityEngine;
using System.Collections;

public class KeyboardMovement : MonoBehaviour {

	public Rigidbody player;

	void Start () {
		if (player == null) {
			player = GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<Rigidbody> ();
		}
	}
	
	void Update () {
		float left = Input.GetAxis ("Row Left");
		float right = Input.GetAxis ("Row Right");
		float intent = Input.GetAxis ("Intent");

		Vector3 leftPos = transform.TransformPoint (new Vector3 (-1, 0, 0));
		Vector3 rightPos = transform.TransformPoint (new Vector3 (1, 0, 0));

		player.AddForceAtPosition (transform.forward * (intent * left), leftPos);
		player.AddForceAtPosition (transform.forward * (intent * right), rightPos);
	}
}
