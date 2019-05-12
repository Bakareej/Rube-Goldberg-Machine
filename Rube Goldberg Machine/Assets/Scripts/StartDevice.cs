using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDevice : MonoBehaviour {

	private float Z;//z pos of ball..
	private Vector3 MousePos;
	private Vector3 Offset;//dieeference between object pos and cursor pos
	private Vector3 NewPos;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Confined;//cursor lock
		transform.position = new Vector3(transform.position.x, transform.position.y, -1.222F);
		
	}

	// Update is called once per frame
	void Update () {

	}


	void OnMouseDown()
	{
		Z = Camera.main.WorldToScreenPoint (transform.position).z;//Z value will be changed back later after being added to mouse pos
		Offset = transform.position - MousetoWorld();


	}

	Vector3 MousetoWorld()
	{
		MousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Z);
		MousePos =Camera.main.ScreenToWorldPoint (MousePos);
		return MousePos;//change the mouse position from pixel/screen coords to world.. adding a Z value to it
	}

	void OnMouseDrag()
	{
		NewPos = MousetoWorld () + Offset;
		if (NewPos.y >= 146.4 && NewPos.y <= 150 
			&& NewPos.x >= 1 && NewPos.x <= 7.25) {//constraint the movement to be inside the device rectangle area
			
			transform.position = NewPos;
		}

	}





}
