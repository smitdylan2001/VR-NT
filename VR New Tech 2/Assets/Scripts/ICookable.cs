using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICookable
{
	bool IsCooked { get; }
	int CookTime { get; }
	void SetTime(int time);
	void SetIsCooked(bool value);
}
