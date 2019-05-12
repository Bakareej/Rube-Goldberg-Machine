using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour {

	private Vector3 SwitchToBall1;
	public Transform Ball1;
	private Vector3 SwitchToBall2;
	public Transform Ball2;
	private Vector3 SwitchToBall3;
	public Transform Ball3;
	private Vector3 SwitchToBall4;
	public Transform Ball4;
	private Vector3 SwitchToBall5;
	public Transform Ball5;
	private Vector3 SwitchToBall6;
	public Transform Ball6;
	private Vector3 SwitchToBall7;
	public Transform Ball7;
	private Vector3 SwitchToBall8;
	public Transform Ball8;
	private Vector3 SwitchToBall9;
	public Transform Ball9;
	public Transform Ball10;

	private Vector3 Offset; //distance we want between camera and ball
	private Vector3 Rotation; //rotation of the camera
	private int CurrentBall;
	private bool FixedAngle; //used for when we want the camera to be fixed

	private float _End = 25;

	// Use this for initialization
	void Start () {

		CurrentBall = 0;
		Offset = new Vector3 (0, 0, -9);
		FixedAngle = false;

		//positions to check for before switching between balls to follow

		SwitchToBall1 = new Vector3(4.15F, 145.87F, -1.403875F);

		SwitchToBall2 = new Vector3(24.262F, 129.12F, -1.47887F);

		SwitchToBall3 = new Vector3(39.33351F, 130.2981F, -1.08405F);

		SwitchToBall4 = new Vector3 (72.7105F, 126.4322F, -1.720258F);

		SwitchToBall5 = new Vector3(81.32573F, 85.57333F, -3.932091F);

		SwitchToBall6 = new Vector3(57.62711F, 84.67061F, -4.655155F);

		SwitchToBall7 = new Vector3(27.23203F, 59.26333F, -5.385463F);

		SwitchToBall8 = new Vector3(46.85421F, 57.93679F, -3.839998F);

		SwitchToBall9 = new Vector3(129.6953F, 32.68333F, -5.808408F);

		
	}

	// Update is called once per frame
	void Update () {
		

		switch (CurrentBall) {
		case 0: //fixed position during start device
			if (Ball1.position.x <= SwitchToBall1.x + 1 && Ball1.position.y <= SwitchToBall1.y + 0.5 &&
				Ball1.position.x >= SwitchToBall1.x - 1 && Ball1.position.y >= SwitchToBall1.y - 0.5) {
				CurrentBall = 1;
			}

			break;

		case 1:

			if (Ball1.position.x <= SwitchToBall2.x + 1 && Ball1.position.y <= SwitchToBall2.y + 0.5 &&
				Ball1.position.x >= SwitchToBall2.x - 1 && Ball1.position.y >= SwitchToBall2.y - 0.5) {

				CurrentBall = 2;
			}
			break;

		case 2:
			if (Ball2.position.x <= SwitchToBall3.x + 0.5 && Ball2.position.y <= SwitchToBall3.y + 0.5 && 
				Ball2.position.x >= SwitchToBall3.x - 0.5 && Ball2.position.y >= SwitchToBall3.y - 0.5) {

				CurrentBall = 3;
				Offset = new Vector3 (0, 3, -9);
				Rotation = new Vector3 (15, 0, 0);
			}

			break;
		case 3:
			if (Ball3.position.x <= SwitchToBall4.x + 1 && Ball3.position.y <= SwitchToBall4.y + 0.5 &&
				Ball3.position.x >= SwitchToBall4.x - 1 && Ball3.position.y >= SwitchToBall4.y - 0.5) {

				CurrentBall = 4;
				Offset = new Vector3 (0, 4, -15);
				Rotation = new Vector3 (15, 0, 0);
			}

			break;

		case 4: // switch to a fixed camera angle when the ball is on the windmill
			if (Ball4.position.x <= 102.7648 && Ball4.position.y <= 103.1536
			    && Ball4.position.x >= 92.62877 && Ball4.position.y >= 88.45095) {

				FixedAngle = true;//fix the camera 

				transform.localRotation = Quaternion.identity;//reset current rotation

				if (transform.localRotation.eulerAngles.y < 90) {//rotate it 
					transform.Rotate (Vector3.up, 90, Space.Self);
				}

				transform.position = new Vector3 (83, 96, -5); //set fixed position

			} else {
				FixedAngle = false;
				if (transform.localRotation.eulerAngles.y > 0) {
					transform.localRotation = Quaternion.identity;//reset current rotation
				}
			}

			//switch to ball 5
			if (Ball4.position.x <= SwitchToBall5.x + 1 && Ball4.position.y <= SwitchToBall5.y + 0.5 &&
				Ball4.position.x >= SwitchToBall5.x - 1 && Ball4.position.y >= SwitchToBall5.y - 0.5) {

				CurrentBall = 5;
				Offset = new Vector3 (0, 4, -20);

			}


			break;

		case 5:
			if (Ball5.position.x <= SwitchToBall6.x + 1 && Ball5.position.y <= SwitchToBall6.y + 0.5 &&
				Ball5.position.x >= SwitchToBall6.x - 1 && Ball5.position.y >= SwitchToBall6.y - 0.5) {

				CurrentBall = 6;
				Offset = new Vector3 (0, 4, -15);

			}
			break;

		case 6:
			if (Ball6.position.x <= SwitchToBall7.x + 1 && Ball6.position.y <= SwitchToBall7.y + 0.5 &&
				Ball6.position.x >= SwitchToBall7.x - 1 && Ball6.position.y >= SwitchToBall7.y - 0.5) {

				CurrentBall = 7;
				Offset = new Vector3 (0, 4, -15);

			}
			break;

		case 7:
			if (Ball7.position.x <= SwitchToBall8.x + 1 && Ball7.position.y <= SwitchToBall8.y + 0.5 &&
				Ball7.position.x >= SwitchToBall8.x - 1 && Ball7.position.y >= SwitchToBall8.y - 0.5) {

				CurrentBall = 8;
				Offset = new Vector3 (0, 4, -15);

			}
			break;

		case 8:
			if (Ball8.position.x <= SwitchToBall9.x + 1 && Ball8.position.y <= SwitchToBall9.y + 0.5 &&
				Ball8.position.x >= SwitchToBall9.x - 1 && Ball8.position.y >= SwitchToBall9.y - 0.5) {

				CurrentBall = 9;
				Offset = new Vector3 (0, 4, -30);

			}
			break;

		case 9: // switch to a fixed camera angle when the ball hits the knife
			if (Ball9.position.x <= 40 && Ball9.position.y <= 42.3
			    && Ball9.position.x >= 37.3 && Ball9.position.y >= 32.3) {

				FixedAngle = true;//fix the camera 

				transform.localRotation = Quaternion.identity;//reset current rotation

				if (transform.localRotation.eulerAngles.y < 40) {//rotate it 
					transform.Rotate (Vector3.up, 40, Space.Self);
				}

				transform.position = new Vector3 (26.8F, 38.9F, -70); //set fixed position
			}

				//switch to ball 10
			if (Ball10.position.x >= 79 && Ball10.position.y >= 5) {
				
				FixedAngle = false;
				CurrentBall = 10;
				Offset = new Vector3 (0, 4, -20);

				if (transform.localRotation.eulerAngles.y > 0) {
					transform.localRotation = Quaternion.identity;//reset current rotation
				}


			}


				
			break;

		case 10:
			
			if (Ball10.position.x <= 99 && Ball10.position.y <= 2
			    && Ball10.position.x >= 97 && Ball10.position.y >= 1) {

				FixedAngle = true;//fix the camera 



				transform.localRotation = Quaternion.identity;//reset current rotation

				if (transform.localRotation.eulerAngles.y > -90) {//rotate it 
					transform.Rotate (Vector3.up, -90, Space.Self);
				}

				if (transform.localRotation.eulerAngles.x < 50) {//rotate it 
					transform.Rotate (Vector3.right, 50, Space.Self);
				}

				transform.position = new Vector3 (134.49F, 22.17F, -19.31F); //set fixed position
			}

			_End -= Time.deltaTime;
				

			if (_End <= 0) {
				SceneManager.LoadScene("EndMenu", LoadSceneMode.Single);
			}
		
			break;
			
		}


		//Debug.Log (CurrentBall);


	}


	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		if (!FixedAngle) {
			switch (CurrentBall) {// Set the position of the camera to the current ball, but offset by the calculated offset distance.

			case 1:
			//Debug.Log ("Ball 1");
				transform.position = Ball1.position + Offset;
				break;
			case 2:
			//Debug.Log ("Ball 2");
				transform.position = Ball2.position + Offset;
				break;
			case 3:
				transform.position = Ball3.position + Offset;
				if (transform.localRotation.eulerAngles.x < Rotation.x) {//rotate the camera
					transform.Rotate (Vector3.right, 1, Space.Self);
				}
				break;
			case 4:
				transform.position = Ball4.position + Offset;
				if (transform.localRotation.eulerAngles.x < Rotation.x) {//rotate the camera
					transform.Rotate (Vector3.right, 1, Space.Self);
				}
				break;
			case 5:
				transform.position = Ball5.position + Offset;
				break;		
			case 6:
				transform.position = Ball6.position + Offset;
				break;
			case 7:
				transform.position = Ball7.position + Offset;
				break;
			case 8:
				transform.position = Ball8.position + Offset;
				break;
			case 9:
				transform.position = Ball9.position + Offset;
				break;
			case 10:
				transform.position = Ball10.position + Offset;
				if (transform.localRotation.eulerAngles.x < Rotation.x) {//rotate the camera
					transform.Rotate (Vector3.right, 1, Space.Self);
				}
				break;
			}
		} else if (FixedAngle) 
		{
			//do nothing for now
		}


	}
}
