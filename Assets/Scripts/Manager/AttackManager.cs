using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour {

	private List<AttackButton> _attack_buttons = new List<AttackButton> ();

	// Use this for initialization
	void Start () {
		_attack_buttons = AttackButton.attack_buttons;
	}
	
	// Update is called once per frame
	void Update () {
		if (AttackState ())
		{
			foreach (AttackButton btn in _attack_buttons)
			{
				btn.gameObject.SetActive (true);
			}
		}


	}

	private bool AttackState()
	{
		return ClickManager.Instance.squad_selected != null;
	}
}
