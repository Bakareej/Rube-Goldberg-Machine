using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformButton : MonoBehaviour {


	public Transform Platform;
	private Vector3 Destination;
	private bool buttonDown = false;
	public int Speed = 5;
	private bool Move = false;
	private Vector3 Old;

	// Use this for initialization
	void Start () {
		Old = transform.position;
		Destination = Platform.position + new Vector3(-7, 0, 0);
	}

	// Update is called once per frame
	void Update () {

		if (buttonDown == true && transform.position.x < (Old.x + 0.7)) {
			transform.Translate(new Vector3(0.1F, 0, 0) * Time.deltaTime);
		} 

		if (buttonDown == false && transform.position.x > Old.x) {
			transform.Translate(new Vector3(-0.1F, 0, 0) * Time.deltaTime);

		}

		if (Move == true && Platform.position.x > Destination.x) {

			Platform.Translate(Vector3.left * Time.deltaTime * Speed);
		}
	}

	void OnCollisionEnter()//move the launch pad!
	{
		Move = true;
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
