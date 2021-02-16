using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliderzoom : MonoBehaviour
{
	public GameObject cube;
	public void Slide_zoomed(float newValue)
	{
		Vector3 pos = cube.transform.position;
		pos.x = newValue;
		cube.transform.position = pos;

	}

}
