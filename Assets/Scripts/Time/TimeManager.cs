using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();

	public static TimedAction CreateTimedAction(float duration, DateInfo date)
	{
		TimedAction action = new TimedAction (Time.time, duration);
		timed_actions.Add (action);
		return action;
	}

	public static void Update(float delta_time)
	{
		foreach (TimedAction timedAction in timed_actions)
		{
			timedAction.Update (delta_time);
		}	
	}

}
