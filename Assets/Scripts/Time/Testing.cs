using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Testing : MonoBehaviour {

	private TimedAction tAction;
	private DateTime date;

	// Use this for initialization
	void Start () {
		tAction = TimeManager.CreateTimedAction (60, DateTime.Now);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
		{
			TimeManager.AddSecondsHack (30f);
		}
		TimeManager.Update ();

		Debug.Log (tAction.action_ratio);
	}
}
