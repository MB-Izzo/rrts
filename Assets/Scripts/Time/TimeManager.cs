using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeManager
{
	public TimedAction CreateTimedAction(float duration)
	{
		return new TimedAction(Time.time, duration);
	}
}
