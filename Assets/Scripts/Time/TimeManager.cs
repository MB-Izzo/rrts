using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();
	private static double secondsToAdd;

	public static TimedAction CreateTimedAction(float duration, DateTime date, ActionType actionType)
	{
		switch (actionType)
		{
		case ActionType.MOVE_TO:
			MoveTo move_to_action = new MoveTo (duration, date, actionType);
			timed_actions.Add (move_to_action);
			return move_to_action;
			break;

		case ActionType.ATTACK:
			Attack attack_action = new Attack (duration, date, actionType);
			timed_actions.Add (attack_action);
			return attack_action;
			break;

		default:
			return null;
			break;
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
