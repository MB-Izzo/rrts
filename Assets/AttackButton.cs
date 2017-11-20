using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour {

	private Button btn;
	public static List<AttackButton> attack_buttons = new List<AttackButton> ();
	public Transform city;

	// Use this for initialization
	void Start () {
		btn = GetComponent<Button> ();
		attack_buttons.Add (this);
		btn.onClick.AddListener (GoToDestination);
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void GoToDestination()
	{
		
	}
}
