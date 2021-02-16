using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nhapxuatkho : MonoBehaviour
{
	private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
		Anim = GetComponent<Animator>();
		Anim.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void nhapkho()
	{
	Anim.Play("nhapkho",-1,0f);
	Anim.speed = 1f;

	}
	public void xuatkho()
	{
		Anim.Play("xuatkho",-1,0f);
		Anim.speed = 1f;

	}
}
