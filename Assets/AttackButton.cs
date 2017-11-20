using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Script attached to a button.
public class AttackButton : MonoBehaviour {

	private Button btn;
	public static List<AttackButton> attack_buttons = new List<AttackButton> ();
	public Transform city;
	private Squad _squad_selected;
	private Vector2 squad_start_pos;

	// Use this for initialization
	void Start () {
		btn = GetComponent<Button> ();
		attack_buttons.Add (this);
		btn.onClick.AddListener (GoToDestination);
	}
	
	// Update is called once per frame
	void Update () {
		_squad_selected = ClickManager.Instance.squad_selected;

	}

	private void GoToDestination()
	{
		print ("clicked");
		MoveAction move_action =_squad_selected.gameObject.AddComponent(typeof(MoveAction)) as MoveAction;
		squad_start_pos = new Vector2 (_squad_selected.transform.position.x, _squad_selected.transform.position.y);
		move_action.start_pos = squad_start_pos;
		move_action.destination = city.position;
		move_action.squad = _squad_selected;
	}


}
