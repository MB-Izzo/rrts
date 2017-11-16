using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimedAction {

	public DateTime time_started { get; private set; }
	public float duration { get; private set; }
	public float action_ratio { get; private set; }
	private float time_progress;
	private float delta;

	public TimedAction(float duration, DateTime date)
	{
		this.time_started = date;
		this.duration = duration;
	}

	public void Update(float delta_time)
	{
		this.time_progress += delta_time;
		action_ratio = time_progress / duration;
		delta = DateInfo.TimeElapsedInSeconds (DateTime.Now, this.time_started);
	}

}

//			timedAction.delta = DateInfo.TimeElapsedInSeconds (DateTime.Now, timedAction.dateOnCreation);
