using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCut : MonoBehaviour { //this will be placed in all the rope joints/bones

	public GameObject Bone;// the part of the rope that will get cut
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			

	}

	void OnCollisionEnter(Collision col)
	{
		//Debug.Log (col.collider.name);
		if (col.collider.name == "14th Floor" || col.collider.name == "Rope") {//if the knife collides with the rope or the floor its on

			Destroy(Bone.GetComponent<CharacterJoint>()); //disconnect the weight from the rope

		}
	}

}
