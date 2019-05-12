using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuButtons : MonoBehaviour {

	public void RestartMachine()
	{
		SceneManager.LoadScene("Rube Goldberg Machine", LoadSceneMode.Single);
	}

	public void QuitMachine()
	{
		Application.Quit();
	}
}
