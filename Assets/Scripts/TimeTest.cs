using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    private GameObject _rightController;
    private GameObject _leftController;
    private Vector3 _rightPosition;
    private Vector3 _leftPosition;
    private Vector3 _rightPositionCache;
    private Vector3 _leftPositionCache;
    private float _motion;

    private void Start()
    {
        _leftController = GameObject.Find("LeftControllerAnchor");
        _rightController = GameObject.Find("RightControllerAnchor");
        _rightPosition = _rightController.transform.position;
        _leftPosition = _leftController.transform.position;

        _rightPositionCache = _rightPosition;
        _leftPositionCache = _leftPosition;
    }

	private void FixedUpdate()
    {
        _rightPosition = _rightController.transform.position;
        _leftPosition = _leftController.transform.position;

        _motion = (((Mathf.Abs(_rightPosition.x - _rightPositionCache.x)) + (Mathf.Abs(_rightPosition.y - _rightPositionCache.y)) + (Mathf.Abs(_rightPosition.z - _rightPositionCache.z)) / 3) + ((Mathf.Abs(_leftPosition.x - _leftPositionCache.x)) + (Mathf.Abs(_leftPosition.y - _leftPositionCache.y)) + (Mathf.Abs(_leftPosition.z - _leftPositionCache.z)) / 3)) / 2;

        _rightPositionCache = _rightPosition;
        _leftPositionCache = _leftPosition;

        Time.timeScale = Mathf.Lerp(Time.timeScale, 1 - (_motion * 30), 0.05f);
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        
    }
}
