using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();

	public static TimedAction CreateTimedAction(float duration)
	{
		TimedAction action = new TimedAction (Time.time, duration);
		timed_actions.Add (action);
		return action;
	}

	private void Update(float delta_time)
	{
		foreach (TimedAction timedActions in timed_actions)
		{
			timedActions.Update (delta_time);
		}	
	}
		
	// Between 0 and 1.
	// private float GetRatio()
	// {
	//	(Time.time - time_started) / this.duration;
	// }

}
