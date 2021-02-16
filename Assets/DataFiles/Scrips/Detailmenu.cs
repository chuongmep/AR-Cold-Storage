using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Detailmenu : MonoBehaviour{
	
public GameObject[] objects;

	bool Show = false;
	public void an ()
	{
		foreach (GameObject obj in objects) {
			obj.SetActive (Show);
		}
			Show = !Show;
		}
		
}

