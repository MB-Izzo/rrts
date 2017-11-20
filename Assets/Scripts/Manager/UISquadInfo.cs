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

	// Use this for initialization
	void Start () {
		
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
			this.panel.SetActive (true);
		}
		else
		{
			this.panel.SetActive (false);
		}
		this.speed.text = "Speed: " + speed + "km/h";
		this.destination.text = "Destination: " + destination + ".";
		this.travel_time.text = "Duration: " + TimeLib.HoursToSpan(travel_time);
		this.squad_name.text = squad_name; 
	}
}
