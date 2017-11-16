using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class DateInfo {
	
	public static double msElapsed(DateTime a, DateTime b)
	{
		double t = b.Subtract (a).TotalMilliseconds;
		double ms = t;
		return ms;
	}
}
