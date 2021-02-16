using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Showhide : MonoBehaviour{
	
public GameObject[] objects;
public GameObject[] menu;
public GameObject Panel;

	bool Show = false;
	bool Hide = true;


	public void an ()
	{
		foreach (GameObject obj in objects) {
			obj.SetActive (Show);
		
		}
	}
	public void hien ()
	{
		foreach (GameObject obj in menu) {
			obj.SetActive (Hide);

		}
	}
	public void OpenPanel ()
	{
		if (Panel != null) {
			bool isActive = Panel.activeSelf;
			Panel.SetActive (!isActive);
			Show = !Show;
		}

	}

}

