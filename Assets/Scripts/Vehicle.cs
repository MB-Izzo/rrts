using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

	public Transform dest;
	private Vector2 start;
	private Vector2 destV;
	private Vector2 dir;


	private float distance;
	private float time;
	public float speed; // in unit/hour.
	private float s;

	// Use this for initialization
	void Start () {
		start = new Vector2 (transform.position.x, transform.position.y);
		destV = new Vector2 (dest.position.x, dest.position.y);

		dir = destV - start;
		dir.Normalize ();

		distance = Vector2.Distance (start, destV); // 20Km = 2 units.
		time = distance / speed; // give time in hour.
		speed = speed * (1 / 3600f); // convert to speed/s (to use with Time.deltaTime)

		float speedInKm = speed * 10;
		float timeInMinutes = time * 60;

		print ("Plane is moving at: " + speedInKm + "km/h");
		print ("It has " + distance * 10 + "km to travel");
		print ("It will take " + timeInMinutes + " minutes");
		// s = d/t
		// t = d/s
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(dir * speed * Time.deltaTime);

	}
}
