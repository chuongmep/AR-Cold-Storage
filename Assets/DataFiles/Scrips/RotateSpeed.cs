using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpeed : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed = 0f;

    void Update()
    {
		transform.Rotate (0, speed * Time.deltaTime, 0);
    }

	public void AdjustSpeed(float newSpeed){
		speed = newSpeed;
	}
}
