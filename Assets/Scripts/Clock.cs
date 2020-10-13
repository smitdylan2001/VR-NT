using UnityEngine;

public class Clock : MonoBehaviour
{
    private GameObject _rotatePoint;
    private GameObject _clockPointer;

    public int Times { get; private set; }
    private bool _canIncreaseTimes;

    private void Start()
    {
        _rotatePoint = GameObject.Find("Rotatepoint");
        _clockPointer = GameObject.Find("Pointer");
        Times = 0;
        _canIncreaseTimes = false;
    }

    private void FixedUpdate()
    {
        Rotate();

        TrackTime();
    }

    private void Rotate()
	{
        _clockPointer.transform.RotateAround(_rotatePoint.transform.position, Vector3.back, Time.fixedDeltaTime * 25);

    }

    private void TrackTime()
	{
        if (_clockPointer.transform.localRotation.eulerAngles.y > 0 && _clockPointer.transform.localRotation.eulerAngles.y < 30 && _canIncreaseTimes)
        {
            Times++;
            _canIncreaseTimes = false;
        }
        if (_clockPointer.transform.localRotation.eulerAngles.y > 60 && !_canIncreaseTimes)
        {
            _canIncreaseTimes = true;
        }
    }
}
