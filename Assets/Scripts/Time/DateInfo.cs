using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DateInfo {

	public DateTime onCreation;
	public DateTime onLoadGame;
	public float secondsElapsed;

	public static float TimeElapsedInSeconds(DateTime a, DateTime b)
	{
		TimeSpan t = b.Subtract (a).TotalSeconds;
		float s = t.Seconds;
		return s;
	}
}
