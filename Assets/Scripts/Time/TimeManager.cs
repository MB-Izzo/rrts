using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeManager {

	private static List<TimedAction> timed_actions = new List<TimedAction>();

	public static TimedAction CreateTimedAction(float duration, System.Action<float> onUpdate)
	{
		TimedAction action = new TimedAction (Time.time, duration, onUpdate);
		timed_actions.Add (action);
		return action;
	}

	private void Update()
	{
		this.UpdateAllTimedActions ();
	}

	private void UpdateAllTimedActions()
	{
		foreach (TimedAction timedActions in timed_actions)
		{
			timedActions.Update ();
		}
	}

}
