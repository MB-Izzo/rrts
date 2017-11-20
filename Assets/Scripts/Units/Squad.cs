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

	// SHOULD NOT BE HERE!
	/*private SpriteRenderer _sprite;
	public Sprite on_selected_sprite;
	private Sprite _default_sprite;
	private bool _isSelected;
	public GameObject unit_panel;
	public Text destination_text;
	public Text time_remaining_text;
	public Text speed_text;
	private string _destination_name;*/

	// Use this for initialization
	void Start () {
		//_sprite = GetComponent<SpriteRenderer> ();
		//_default_sprite = _sprite.sprite;
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
		transform.position = Vector2.Lerp(_start_pos, _destination_pos, _travel_action.ratio);

		/* Should not be here.
		TimeSpan span = TimeSpan.FromSeconds (_travel_action.time_remaining);
		int minutes = span.Minutes;
		OnClick ();
		if (_isSelected)
		{
			unit_panel.SetActive (true);
			speed_text.text = "Speed: " + _speed_km + "km/h";
			destination_text.text = "Going to: " + _destination_name;
			time_remaining_text.text = "Time remaining: " + minutes + " minutes";

		}
		else
		{
			unit_panel.SetActive (false);
		}
		*/
	}
		
	// should not be here.
	/*
	void OnClick()
	{
		if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll (ray);
			for (int i = 0; i < hits.Length; i++)
			{
				if (hits [i].collider.CompareTag ("Soldier"))
				{
					_sprite.sprite = on_selected_sprite;
					_isSelected = true;

				}
				else
				{
					_sprite.sprite = _default_sprite;
					_isSelected = false;
				}
			}
		}

	} */
}

