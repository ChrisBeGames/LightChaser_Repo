using UnityEngine;
using System.Collections;

public class Brazier : MonoBehaviour {

	public bool isLit;
	public ParticleSystem particleSystem;

	void OnTriggerEnter (Collider other) {
		print ("Enter");
		if (other.tag == "Ignitor") {
			isLit = true;
			particleSystem.enableEmission = true;
		}
	}

	void OnTriggerExit (Collider other) {

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (particleSystem) {
			if (isLit && !particleSystem.enableEmission) {
				OnTriggerEnter (GameObject.FindGameObjectWithTag ("Ignitor").GetComponent<Collider> ());
			} else if (!isLit && particleSystem.enableEmission) {
				particleSystem.enableEmission = false;
			}
		}
	}
}
