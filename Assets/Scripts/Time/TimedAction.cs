using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAction {

	public float _time_started { get; private set; }
	public float _duration { get; private set; }

	public TimedAction(float time_started, float duration)
	{
		_time_started = time_started;
		_duration = duration;
	}
}
