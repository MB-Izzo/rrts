using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();
	private static double secondsToAdd;

	public static TimedAction CreateTimedAction(float duration, DateTime date)
	{
		TimedAction action = new TimedAction (duration, date);
		timed_actions.Add (action);
		return action;
	}

	public static TimedAction CreateTimedAction(TimedAction existing_action)
	{
		TimedAction action = existing_action;
		timed_actions.Add (action);
		return action;
	}

	public static TimedAction CreateTimedAction(string timed_action_json)
	{
		TimedAction action = JsonUtility.FromJson<TimedAction> (timed_action_json);
		CreateTimedAction (action);
		return action;
	}

	public static void Update()
	{
		foreach (TimedAction timedAction in timed_actions)
		{
			timedAction.Update (DateTime.Now.AddSeconds(secondsToAdd));
		}	
	}

	// Don't push your hacks
	public static void AddSecondsHack (double s)
	{
		secondsToAdd += s;
	}

}
