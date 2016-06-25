using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		transform.position = col.transform.position;
		Joint joint = gameObject.AddComponent <FixedJoint>();
		joint.connectedBody = col.GetComponent<Rigidbody>();
	}
}
