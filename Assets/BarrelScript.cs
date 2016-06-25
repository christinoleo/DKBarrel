using UnityEngine;
using System.Collections;

public class BarrelScript : MonoBehaviour {

	public GameObject sphere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Destroy (sphere.GetComponent<FixedJoint> ());
			sphere.GetComponent<Rigidbody> ().AddForce (transform.up * 800);

		}
	}
}
