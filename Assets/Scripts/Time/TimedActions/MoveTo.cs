using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveTo : TimedAction {

	public City destination;

	public MoveTo (float duration, DateTime date) : base (duration, date)
	{
		
	}

	public override void Update(DateTime date)
	{
		base.Update (date);
		//move to city
	}

}
