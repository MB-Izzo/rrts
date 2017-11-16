using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimedAction {

	public float time_started { get; private set; }
	public DateInfo date;
	public float duration { get; private set; }
	public float action_ratio { get; private set; }
	private float time_progress;

	public TimedAction(float time_started, float duration, DateInfo date)
	{
		this.time_started = time_started;
		this.date.onCreation = date.onCreation;
		this.date.onLoadGame = date.onLoadGame;
		this.date.secondsElapsed = DateInfo.TimeElapsedInSeconds (date.onLoadGame, date.onCreation);
		this.duration = duration;

	}

	public void Update(float delta_time)
	{
		this.time_progress += delta_time;
		action_ratio = time_progress / duration;
	}

}