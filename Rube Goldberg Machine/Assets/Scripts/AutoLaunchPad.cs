using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLaunchPad : MonoBehaviour {

	public Rigidbody Ball;
	private Vector3 Destination;
	public int Speed = 10;
	public float Force;
	private bool Launch = false;


	// Use this for initialization
	void Start () {
		
		Destination = transform.position + new Vector3(0, 12, 0);
	}

	// Update is called once per frame
	void Update () {

		if (Launch == true && transform.position.y < Destination.y) {
		
			transform.Translate (Vector3.up * Time.deltaTime * Speed);

			Ball.AddForce (Vector3.up * Force);
		}
	}

	void OnCollisionEnter()//move the launch pad!
	{
		Launch = true;

	}
}
