using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveAction : MonoBehaviour {

	public float _travel_time;
	public Vector2 start_pos;
	public Vector2 destination;
	private TimedAction action;
	public Squad squad;


	// Use this for initialization
	void Start () {
		float distance = Vector2.Distance (start_pos, destination);
		_travel_time = distance / squad.speed;
		float _travel_time_seconds = _travel_time * 3600f;
		action = TimedActionFactory.CreateTimedAction (_travel_time_seconds, DateTime.Now);
		Debug.Log (_travel_time_seconds);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.Lerp(start_pos, destination, action.ratio);
	}

}
