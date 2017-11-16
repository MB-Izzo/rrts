using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class DateInfo {
	
	public static float msElapsed(DateTime a, DateTime b)
	{
		TimeSpan t = b.Subtract (a).TotalMilliseconds;
		float ms = t.TotalMilliseconds;
		return ms;
	}
}
