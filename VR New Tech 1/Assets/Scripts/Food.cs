using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour , ICookable
{
	Food(bool value, int time)
	{
		SetIsCooked(false);
		SetTime(time);
	}

	private void Start()
	{
		IsCooked = false;
		CookTime = 3;
	}

	public bool IsCooked { get; private set; }
	public int CookTime { get; private set; }

	public void SetIsCooked(bool value)
	{
		IsCooked = value;
	}

	public void SetTime(int time)
	{
		CookTime = time;
	}
}
