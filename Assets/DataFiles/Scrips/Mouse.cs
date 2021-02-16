using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
	Vector3 mPrevPos = Vector3.zero;
	Vector3 mPosDelta= Vector3.zero;
	float mRotSpeed =0.0f;

    // Update is called once per frame
    void Update()
	{
		if (Input.GetMouseButtonDown(0))

		{

			mRotSpeed = 1.0f;

			mPrevPos = Input.mousePosition;
		}
		else if(Input.GetMouseButton(0))
		{
			mPosDelta = Input.mousePosition - mPrevPos;
			if(Vector3.Dot(transform.up, Vector3.up) >= 0)
			{
				transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
				mRotSpeed = 1.0f;
			}
			else
			{
				transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
				mRotSpeed = -1.0f;
			}
			transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);

			mPrevPos = Input.mousePosition;
		}
		else
		{
			mRotSpeed *= 0.99f;
			Vector3 updatedDelta = new Vector3(mPosDelta.x * mRotSpeed, mPosDelta.y * Mathf.Abs(mRotSpeed), 0.0f);
			transform.Rotate(Camera.main.transform.right, Vector3.Dot(updatedDelta, Camera.main.transform.up) , Space.World);
			transform.Rotate(transform.up, -Vector3.Dot(updatedDelta, Camera.main.transform.right), Space.World);
		}

		mPrevPos = Input.mousePosition;
}
}
