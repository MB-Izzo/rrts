using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class DateInfo {
	
	public static float TimeElapsedInSeconds(DateTime a, DateTime b)
	{
		TimeSpan t = b.Subtract (a).TotalSeconds;
		float s = t.Seconds;
		return s;
	}
}
