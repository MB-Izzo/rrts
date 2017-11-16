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

	public void Update(DateTime date)
	{
		this.time_progress += DateInfo.msElapsed(date, time_started);
		action_ratio = time_progress / duration;
	}

}

//			timedAction.delta = DateInfo.TimeElapsedInSeconds (DateTime.Now, timedAction.dateOnCreation);
