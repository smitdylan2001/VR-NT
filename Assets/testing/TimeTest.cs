using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    
    public GameObject test;

    void Start()
    {
        
    }

	private void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
            Time.timeScale /= 2;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
	}

	void fixedUpdate()
    {
        
    }
}
