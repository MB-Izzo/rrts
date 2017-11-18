using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : TimedAction {

	public City target;

	public Attack (float duration, DateTime date, ActionType actionType) : base (duration, date, actionType)
	{

	}

	public void Update(DateTime date)
	{
		base.Update (date);
		//move to city
	}

}
