using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAction {

	public float time_started { get; private set; }
	public float duration { get; private set; }
	public float action_ratio { get; private set; }
	private float time_progress;

	public TimedAction(float time_started, float duration)
	{
		this.time_started = time_started;
		this.duration = duration;
	}

	public void Update(float delta_time)
	{
		this.time_progress += delta_time;
		action_ratio = time_progress / duration;
	}

}