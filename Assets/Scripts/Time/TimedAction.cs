using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimedAction {

	public DateTime time_started { get; private set; }
	public float duration { get; private set; }
	public double action_ratio { get; private set; }
	public double time_progress { get; private set; }
	public double _delta { get; private set; }
	private DateTime last_date = DateTime.Now;

	public TimedAction(float duration, DateTime date)
	{
		this.time_started = date;
		this.duration = duration;
	}

	public void Update(DateTime new_date)
	{
		_delta = MsElapsed (new_date, last_date);
		this.time_progress += _delta/1000f;
		action_ratio = time_progress / duration;
		last_date = new_date;
		Mathf.Min ((float)action_ratio, 1f);
	}

	public double MsElapsed(DateTime a, DateTime b)
	{
		return a.Subtract (b).TotalMilliseconds;
	}

}