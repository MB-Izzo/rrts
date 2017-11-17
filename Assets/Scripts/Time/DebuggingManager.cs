using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DebuggingManager : MonoBehaviour {

	public static DebuggingManager instance = null;
	public float secondsOnSpace;

	private TimedAction testAction;

	// Use this for initialization
	void Start () {
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy (gameObject);
		}
		testAction = TimeManager.CreateTimedAction (60, DateTime.Now);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
		{
			TimeManager.AddSecondsHack (secondsOnSpace);
		}
		TimeManager.Update ();
        Debug.Log (testAction.SerializeToJSON());
	}
}
