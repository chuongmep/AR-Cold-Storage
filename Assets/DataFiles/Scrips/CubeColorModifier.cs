using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class CubeColorModifier : MonoBehaviour {
	public MeshRenderer cube;
	public MeshRenderer themic;
	public MeshRenderer vonke;
	public Slider red;
	public Slider green;
	public Slider blue;


	public void OnEdit ()
	{
		Color color = cube.material.color;
		color.r = red.value;
		color.g = green.value;
		color.b = blue.value;
		cube.material.color = color;
		cube.material.SetColor("_EmissionColor", color);
		themic.material.color = color;
		themic.material.SetColor("_EmissionColor", color);
		vonke.material.color = color;
		vonke.material.SetColor("_EmissionColor", color);


	}
}