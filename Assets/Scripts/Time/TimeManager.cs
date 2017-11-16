using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeManager : MonoBehaviour {

	public TimedAction CreateTimedAction(float duration)
	{
		return new TimedAction (Time.time, duration);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
