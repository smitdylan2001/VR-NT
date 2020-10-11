using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    public GameObject rightController;
    public GameObject leftController;
    public Vector3 rightPosition;
    public Vector3 leftPosition;
    public Vector3 rightPositionCache;
    public Vector3 leftPositionCache;
    float motion;

    void Start()
    {
        rightPosition = rightController.transform.position;
        leftPosition = leftController.transform.position;

        rightPositionCache = rightPosition;
        leftPositionCache = leftPosition;
    }

    
	private void Update()
	{
        
	}

	private void FixedUpdate()
    {
        rightPosition = rightController.transform.position;
        leftPosition = leftController.transform.position;

        motion = (((Mathf.Abs(rightPosition.x - rightPositionCache.x)) + (Mathf.Abs(rightPosition.y - rightPositionCache.y)) + (Mathf.Abs(rightPosition.z - rightPositionCache.z)) / 3) + ((Mathf.Abs(leftPosition.x - leftPositionCache.x)) + (Mathf.Abs(leftPosition.y - leftPositionCache.y)) + (Mathf.Abs(leftPosition.z - leftPositionCache.z)) / 3)) / 2;

        rightPositionCache = rightPosition;
        leftPositionCache = leftPosition;

        Debug.Log(motion);

        
         Time.timeScale = Mathf.Lerp(Time.timeScale, 1 - (motion * 30), 0.05f);
         Time.fixedDeltaTime = Time.timeScale * 0.02f;
        
    }
}
