using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();

	public static TimedAction CreateTimedAction(float duration, DateInfo date)
	{
		TimedAction action = new TimedAction (duration, DateTime.Now);
		timed_actions.Add (action);
		return action;
	}

	public static void Update()
	{
		foreach (TimedAction timedAction in timed_actions)
		{
			timedAction.Update (DateTime.Now);
		}	
	}
}
