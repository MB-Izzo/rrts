using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();
	private static double secondsToAdd;

	// Maybe this should not be a factory?
	public static TimedAction CreateTimedAction(float duration, DateTime date, string actionType)
	{
		switch (actionType)
		{
		case "MOVE_TO":
			MoveTo move_to_action = new MoveTo (duration, date);
			timed_actions.Add (move_to_action);
			return move_to_action;

		case "ATTACK":
			Attack attack_action = new Attack (duration, date);
			timed_actions.Add (attack_action);
			return attack_action;

		default:
			return null;
		}

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
		action.DeserializeDate ();
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
