using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : TimedAction {

	public City target;

	public Attack (float duration, DateTime date) : base (duration, date)
	{

	}

	public override void Update(DateTime date)
	{
		base.Update (date);
		//move to city
	}

}
