using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Testing : MonoBehaviour {

	private TimedAction tAction;

	// Use this for initialization
	void Start () {
		tAction = TimeManager.CreateTimedAction (5, DateTime.Now);
	}
	
	// Update is called once per frame
	void Update () {
		tAction.Update(DateTime.Now);
		Debug.Log (tAction.action_ratio);
	}
}
