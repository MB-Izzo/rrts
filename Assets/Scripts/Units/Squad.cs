using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Squad : MonoBehaviour {

	public float speed; // 1unit = 10KM. 5=50Km/h
	private float _speed_km;
	private float _distance;
	public Transform destination;
	private Vector2 _start_pos;
	private Vector2 _destination_pos;
	private float _travel_time;
	private float _travel_time_seconds;
	private Unit[] _units;
	private TimedAction _travel_action;
	private string _squad_name;

	// accessors
	public string squad_name;
	public float traval_time { get { return _travel_time; } }
	public string destination_name { get; private set; }
	public float speed_km { get { return _speed_km; } }

	void Start () {
		destination_name = "Bastia";
		_speed_km = speed * 10;
		_start_pos = new Vector2 (transform.position.x, transform.position.y);
		_destination_pos = new Vector2 (destination.transform.position.x, destination.transform.position.y);
		_distance = Vector2.Distance (_start_pos, _destination_pos); // 20Km = 2units.
		_travel_time = _distance / speed; // give travel_time in hour.
		_travel_time_seconds = _travel_time * 3600f;
		speed = speed * (1/3600f); // convert to speed/s. (to use with delta)
		_travel_action = TimedActionFactory.CreateTimedAction(_travel_time_seconds, DateTime.Now);


		// For debugging purposes.
		Debug.Log ("Travel distance: " + _distance * 10 + "km.");
		Debug.Log ("Speed: " + _speed_km + "km/h");
		Debug.Log ("Travel time: " + TimeLib.HoursToSpan(_travel_time));
	}
	
	void Update () {
		TimeManager.Update ();
	}

	public void MoveTo(Vector2 start_pos, Vector2 destination_pos, float action_ratio)
	{
		transform.position = Vector2.Lerp(start_pos, destination_pos, action_ratio);
	}

}

