using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace program
{
public class BackandClose2 : MonoBehaviour
{
	public void Back()
	{
		SceneManager.LoadScene ("Sences menu");
	}
	public void Close ()
		{
			Application.Quit ();
			Debug.Log ("Close");
		}

	}

}


