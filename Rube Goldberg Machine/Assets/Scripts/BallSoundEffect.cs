using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundEffect : MonoBehaviour {

	private AudioSource Pong;
	// Use this for initialization
	void Start () {

		Pong = GetComponent<AudioSource> ();	

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{

		if ((/*!col.collider.name.Contains ("Floor") && !col.collider.name.Contains ("Path") &&*/ 
			!col.collider.name.Contains ("Wall") && !col.collider.name.Contains ("Slope")  &&
			!col.collider.name.Contains ("Background")  && !col.collider.name.Contains ("Platform")&& 
			!col.collider.name.Contains ("Button"))) {
			if (col.relativeVelocity.magnitude >= 3) {
				//Debug.Log (col.collider.name);
				Pong.volume = (col.relativeVelocity.magnitude/20);
				Pong.Play ();
			}
		}
	}
}
