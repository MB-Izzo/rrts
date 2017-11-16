using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeManager {

	private List<TimedAction> timed_actions;

	public static TimedAction CreateTimedAction(float duration)
	{
		TimedAction action = new TimedAction (Time.time, duration);
		timed_actions.Add (action);
		return action;
	}


}
