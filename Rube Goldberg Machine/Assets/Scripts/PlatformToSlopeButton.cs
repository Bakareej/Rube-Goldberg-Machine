using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformToSlopeButton : MonoBehaviour {

	public Transform Platform;
	public int Angle = 7;
	private bool buttonDown = false;
	private bool Rotate = false;
	private Vector3 Old;
	private double _time;

	// Use this for initialization
	void Start () {
		Old = transform.position;
	}

	// Update is called once per frame
	void Update () {

		if (buttonDown == true && transform.position.x > (Old.x - 0.6)) {
			transform.Translate(new Vector3(-0.2F, 0, 0) * Time.deltaTime);
		} 

		if (buttonDown == false && transform.position.x < Old.x) {
			transform.Translate(new Vector3(0.2F, 0, 0) * Time.deltaTime);


		}

		if (Rotate == true && Time.time <= _time + 5 ) {

			Platform.RotateAround( new Vector3(2.64F, 65.88F, -4.63F), Vector3.back, Angle * Time.deltaTime);
		}
	}

	void OnCollisionEnter()
	{
		Rotate = true;
		_time = Time.time;
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
