using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAction {

	public float time_started { get; private set; }
	public float duration { get; private set; }
	public float action_ratio { get; private set; }

	public TimedAction(float time_started, float duration)
	{
		this.time_started = time_started;
		this.duration = duration;
	}

	public void Update(float delta_time)
	{
	}
}
