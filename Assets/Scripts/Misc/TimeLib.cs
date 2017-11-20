using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeLib {

	public static string HoursToSpan(float hours)
	{
		TimeSpan span = TimeSpan.FromHours ((double)hours);
		return string.Format ("{0}:{1:00}:{2:00}",
			(int)span.Hours, span.Minutes, span.Seconds);
	}

}
