using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISquadInfo : MonoBehaviour {

	public GameObject panel;
	public Text speed;
	public Text destination;
	public Text travel_time;
	public Text squad_name;
	private Animator _animator;

	// Use this for initialization
	void Start () {
		_animator = panel.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable()
	{
		OnClickBehavior.updateUI += this.UpdateUI;
	}

	void OnDisable()
	{
		OnClickBehavior.updateUI -= this.UpdateUI;
	}

	private void UpdateUI(float speed, string destination, float travel_time, string squad_name, bool show)
	{
		if (show)
		{
			_animator.SetTrigger ("Open");
		}
		else
		{
			_animator.SetTrigger ("Closed");
		}
		this.speed.text = "Speed: " + speed + "km/h";
		this.destination.text = "Destination: " + destination + ".";
		this.travel_time.text = "Duration: " + TimeLib.HoursToSpan(travel_time);
		this.squad_name.text = squad_name; 
	}
}
