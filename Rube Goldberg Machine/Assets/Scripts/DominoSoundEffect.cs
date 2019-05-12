using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoSoundEffect : MonoBehaviour {
	
	private AudioSource Domino;
	// Use this for initialization
	void Start () {

		Domino = GetComponent<AudioSource> ();	

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col)
	{

		if ((!col.collider.name.Contains ("Wall") && !col.collider.name.Contains ("Path"))) {
			if (col.relativeVelocity.magnitude >= 1) {
				//Debug.Log (col.collider.name);
				Domino.volume = (col.relativeVelocity.magnitude/10);
				Domino.Play ();
			}
		}
	}
}
