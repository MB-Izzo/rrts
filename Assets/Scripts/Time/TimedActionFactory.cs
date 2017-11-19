using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimedActionFactory {

	public static TimedAction CreateTimedAction(float duration, DateTime date, string action_type)
	{
		TimedAction new_action = null;
		switch (action_type)
		{
		case "MOVE_TO":
			new_action = new MoveTo (duration, date);
			break;
		case "ATTACK":
			new_action = new Attack(duration, date);
			break;
		default:
			break;
		}
		if (new_action != null)
		{
			TimeManager.RegisterTimedAction (new_action);
		}
		return new_action;
	}

	public static TimedAction CreateTimedAction(TimedAction existing_action)
	{
		TimedAction new_action = existing_action;
		TimeManager.RegisterTimedAction (new_action);
	}

	public static TimedAction CreateTimedAction(string timed_action_json)
	{
		TimedAction new_action = JsonUtility.FromJson<TimedAction> (timed_action_json);
		new_action.DeserializeDate ();
		CreateTimedAction (new_action);
		return new_action;
	}
}
