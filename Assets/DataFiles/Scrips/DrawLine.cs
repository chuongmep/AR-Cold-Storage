using System.Collections;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
	    private LineRenderer LineRenderer;
	    
	    private float dist;

	    public Transform cube1;
	    public Transform cube2;

	    public float LineDrawSpeed = 1f;



	    // Start is called before the first frame update
	    void Start()
	    {
		        LineRenderer = GetComponent<LineRenderer> ();
		        LineRenderer.SetPosition (0, cube1.position);
		        LineRenderer.startWidth = 1f;
		        LineRenderer.endWidth = 1f;
		        dist = Vector3.Distance(cube1.position, cube2.position);

		    }
	    // Update is called once per frame
	    void Update()
	{
		LineRenderer.SetPosition(0, new Vector3(cube1.transform.position.x,cube1.transform.position.y,cube1.transform.position.z));
		LineRenderer.SetPosition(1, new Vector3(cube2.transform.position.x,cube2.transform.position.y,cube2.transform.position.z));

	}
}
