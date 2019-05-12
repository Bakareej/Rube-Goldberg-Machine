using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideLaunchButton : MonoBehaviour {

	public Rigidbody Ball;
	public Transform Platform;
	private Vector3 Destination;
	private bool buttonDown = false;
	public int Speed = 10;
	public float Force = 10;
	private bool Launch = false;
	private Vector3 Old;



	// Use this for initialization
	void Start () {
		Old = transform.position;
		Destination = Platform.position + new Vector3(4.5F, 0, 0);
	}

	// Update is called once per frame
	void Update () {

		if (buttonDown == true && transform.position.x < (Old.x + 0.7)) {
			transform.Translate(new Vector3(0.1F, 0, 0) * Time.deltaTime);
		} 

		if (buttonDown == false && transform.position.x > Old.x) {
			transform.Translate(new Vector3(-0.1F, 0, 0) * Time.deltaTime);

		}

		if (Launch == true && Platform.position.x < Destination.x) {

			Platform.Translate (Vector3.right * Time.deltaTime * Speed);
			Ball.AddForce (Vector3.right * Force);

		}

	}

	void OnCollisionEnter()//move the launch pad!
	{
		Launch = true;

	}

	void OnCollisionStay()
	{
		buttonDown = true;

	}

	void OnCollisionExit()
	{
		buttonDown = false;
	}

}
