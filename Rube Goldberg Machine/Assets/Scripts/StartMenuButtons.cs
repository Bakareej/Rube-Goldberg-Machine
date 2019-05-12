using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour {

	public void StartMachine()
	{
		SceneManager.LoadScene ("Rube Goldberg Machine", LoadSceneMode.Single);
	}


	public void QuitMachine()
	{
		Application.Quit();
	}
}
