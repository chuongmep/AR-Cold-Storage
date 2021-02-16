using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Changesence : MonoBehaviour {
	public void Thietbi()
	{
		SceneManager.LoadScene ("Thietbi");	
	}
	public void Scan3d()
	{
		SceneManager.LoadScene ("Scan3d");
	}
	public void maylanh()
	{
		SceneManager.LoadScene ("Maylanh");
	}
	public void kholanh()
	{
		SceneManager.LoadScene ("Kholanh");
	}
	public void thoat()
	{
		Application.Quit ();
		Debug.Log("nut thoat");
	}
}
