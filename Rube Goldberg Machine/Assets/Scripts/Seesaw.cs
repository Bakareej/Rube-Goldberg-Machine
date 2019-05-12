using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw : MonoBehaviour {

	private bool Hit = false;
	private int cntr = 0;
	public Rigidbody Ball;
	public float Force;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Hit == true && cntr < 30) {//enough to rotate it to the opposite side
			transform.Rotate (new Vector3 (0, 0, 1), Space.Self);
			cntr++;
			Ball.isKinematic = false; //launch the ball!
			Ball.AddForce (new Vector3(2, 1, 0) * Force);
		}
		
	}

	void OnCollisionEnter(Collision col)
	{
		//Debug.Log (col.collider.name);
		if (col.collider.name == "14th Weight") {//if the weight hit the seesaw

			Hit = true;

		}
	}
}
