using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackandClose : MonoBehaviour
{
	public void Back()
	{
		SceneManager.LoadScene ("Sences menu");
	}
	public void Close()

	{
		Application.Quit ();
		Debug.Log ("Close");
	}
}

