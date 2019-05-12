using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPadButton : MonoBehaviour {

	public Transform Platform;
	private Vector3 Destination;
	private bool buttonDown = false;
	public int Speed = 5;
	private bool Launch = false;
	private Vector3 Old;

	// Use this for initialization
	void Start () {
		Old = transform.position;
		Destination = Platform.position + new Vector3(0, 4, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (buttonDown == true && transform.position.y > (Old.y - 0.7)) {
			transform.Translate(new Vector3(0, -0.1F, 0) * Time.deltaTime);
		} 

		if (buttonDown == false && transform.position.y < Old.y) {
			transform.Translate(new Vector3(0, 0.1F, 0) * Time.deltaTime);

		}

		if (Launch == true && Platform.position.y < Destination.y) {

			Platform.Translate(Vector3.up * Time.deltaTime * Speed);
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
