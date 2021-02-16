using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Detail : MonoBehaviour{
	
public GameObject[] objects;

	bool Show = true;
	public void an ()
	{
		foreach (GameObject obj in objects) {
			obj.SetActive (Show);
		}
			Show = !Show;
		}
		
}

