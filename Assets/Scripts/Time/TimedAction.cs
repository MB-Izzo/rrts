using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimedAction {

	public DateTime time_started { get; private set; }
	public float duration { get; private set; }
	public double action_ratio { get; private set; }
	public double time_progress { get; private set; }
	private float delta;

	public TimedAction(float duration, DateTime date)
	{
		this.time_started = date;
		this.duration = duration;
	}

	public void Update(DateTime date)
	{
		this.time_progress += MsElapsed(date, time_started);
		action_ratio = time_progress / duration;
	}

	public double MsElapsed(DateTime a, DateTime b)
	{
		TimeSpan t = a.Subtract (b);
		return t.TotalMilliseconds;
	}

}

//			timedAction.delta = DateInfo.TimeElapsedInSeconds (DateTime.Now, timedAction.dateOnCreation);
