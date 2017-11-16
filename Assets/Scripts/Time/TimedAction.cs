using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAction {

	public float time_started { get; private set; }
	public float duration { get; private set; }
	public float action_ratio { get; private set; }

	private float _startTime;
	private bool _isCompleted;
	private readonly System.Action<float> _onUpdate;

	public TimedAction(float time_started, float duration, System.Action<float> _onUpdate)
	{
		this.time_started = time_started;
		this.duration = duration;
		this._onUpdate = _onUpdate;
		this._startTime = GetWorldTime ();
	}

	public void Update(float delta_time)
	{
		if (this._isCompleted)
		{
			return;
		}

		if (this._onUpdate != null)
		{
			this._onUpdate (this.GetTimeElapsed());
		}
	}

	// Get how many seconds have elapsed since the start of this timer.
	private float GetTimeElapsed()
	{
		if (_isCompleted)
		{
			return this.duration;
		}
		return GetWorldTime () - _startTime;
	}

	private float GetWorldTime()
	{
		return Time.time;
	}

	// Between 0 and 1.
	private float GetRatio()
	{
		GetTimeElapsed () / this.duration;
	}
}