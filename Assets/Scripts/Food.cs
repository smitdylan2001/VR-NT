using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Component , ICookable
{
	Food(bool value, int time)
	{
		SetIsCooked(false);
		SetTime(time);
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
